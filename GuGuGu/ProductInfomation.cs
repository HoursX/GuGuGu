using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuGuGu
{
    public partial class ProductInfomation : Form
    {
        string op = null;
        int selectRow = 0;
        DataTable tableSuppliers = null;
        DataTable tableCategories = null;
        public ProductInfomation()
        {
            InitializeComponent();
        }
        private void ProRefresh()
        {
            string sql = @"select ProductID as '商品号',ProductName as '商品名称',CompanyName as '供应商名',categoryname as '类别名',UnitPrice as '单价',ThrValue as '阈值', Discont as '折扣' from Products Left join Categories on categories.categoryID = Products.CategoryID Left join Suppliers on suppliers.supplierID = products.supplierID";
            DGVProduct.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void SetEnable(bool id, bool name, bool supname, bool catename, bool unitp, bool value, bool select,string lbTip, bool btnEnable, string btnok, bool exitop, string op)
        {
            TbProductID.Enabled = id;
            TbProductName.Enabled = name;
            CbxCompanyName.Enabled = supname;
            CbxCategoryName.Enabled = catename;
            TbUnitPrice.Enabled = unitp;
            TbValue.Enabled = value;
            GbSelect.Enabled = select;
            LbTip.Text = lbTip;
            btnOK.Enabled = btnEnable;
            btnOK.Text = btnok;
            BtnExit.Enabled = exitop;
            this.op = op;
        }
        private void TextBoxEmpty()
        {
            TbProductID.Text = "";
            TbProductName.Text = "";
            CbxCompanyName.SelectedIndex = 0;
            CbxCategoryName.SelectedIndex = 0;
            TbUnitPrice.Text = "";
            TbValue.Text = "";
            RbOK.Checked = false;
            RbNO.Checked = false;
        }
        private void TextBoxFill()
        {
            TbProductID.Text = DGVProduct.Rows[selectRow].Cells["商品号"].Value.ToString();
            TbProductName.Text = DGVProduct.Rows[selectRow].Cells["商品名称"].Value.ToString();
            for (int i = 1; i < tableSuppliers.Rows.Count; i++)
            {
                if (DGVProduct.Rows[selectRow].Cells["供应商名"].Value.ToString().Trim() == tableSuppliers.Rows[i]["CompanyName"].ToString())
                {
                    CbxCompanyName.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 1; i < tableCategories.Rows.Count; i++)
            {
                if (DGVProduct.Rows[selectRow].Cells["类别名"].Value.ToString().Trim() == tableCategories.Rows[i]["CategoryName"].ToString())
                {
                    CbxCategoryName.SelectedIndex = i;
                    break;
                }
            }
            TbUnitPrice.Text = DGVProduct.Rows[selectRow].Cells["单价"].Value.ToString();
            TbValue.Text = DGVProduct.Rows[selectRow].Cells["阈值"].Value.ToString();
            if (Convert.ToBoolean(DGVProduct.Rows[selectRow].Cells["折扣"].Value)) RbOK.Checked = true;
            else RbNO.Checked = true;
        }
        private void ProductInfomation_Load(object sender, EventArgs e)
        {
            {
                string sql = "select SupplierID,CompanyName from dbo.Suppliers";
                tableSuppliers = GuGuGuHelper.ExecuteReaderDataTable(sql);
                GuGuGuHelper.BindCombo(this.CbxCompanyName, tableSuppliers, "SupplierID", "CompanyName",true);
            }
            {
                string sql = "select CategoryID,CategoryName from dbo.Categories";
                tableCategories = GuGuGuHelper.ExecuteReaderDataTable(sql);
                GuGuGuHelper.BindCombo(this.CbxCategoryName, tableCategories, "CategoryID", "CategoryName", true);
            }
            ProRefresh();
            DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProduct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetEnable(false, false, false, false, false, false, false, "请选择操作模式", false, "确定", false, "other");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetEnable(true, true, true, true, true, true, true, "当前操作模式：查询", true, "查询", true, "query");
        }
        private void Insert()
        {
            List<string> sqlList = new List<string>();
            {
                string sql = "Insert into Products values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                sql = string.Format(sql, TbProductID.Text, TbProductName.Text, CbxCompanyName.SelectedValue, CbxCategoryName.SelectedValue, TbUnitPrice.Text, TbProductName.Text, TbValue.Text.Trim(), RbOK.Checked);
                sqlList.Add(sql);
            }
            {
                string sql = "Insert into Inventory values('{0}','{1}','{2}')";
                sql = string.Format(sql, TbProductID.Text, "0", "千克/箱");
                sqlList.Add(sql);
            }
            int cnt = GuGuGuHelper.ExecuteNonQueryTransaction(sqlList);
            if (cnt == 2)
                MessageBox.Show("添加成功");
            else
                MessageBox.Show("添加失败");
            ProRefresh();
        }
        private void Updates()
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProduct))
            {
                string sql = "Update Products set ProductName = '" + TbProductName.Text.Trim() + "',SupplierID = '" + CbxCompanyName.SelectedValue + "',CategoryID = '" + CbxCategoryName.SelectedValue + "',UnitPrice = '" + TbUnitPrice.Text.Trim() + "', ThrValue = '"+TbValue.Text+ "', Discont = '"+RbOK.Checked+"' where ProductID = '" + TbProductID.Text.Trim() + "'";
                int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
                if (cnt >= 1) MessageBox.Show("修改成功");
                else MessageBox.Show("修改失败");
                ProRefresh();      
            }
            else
            {
                MessageBox.Show("请选择正确的行");
            }
           
        }
        private void Delete()
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProduct))
            {
                string checkSql = "select * from Inventory where ProductID = '" + TbProductID.Text + "'and quantity!=0";
                if (!GuGuGuHelper.ExcuteExist(checkSql))
                {
                    List<string> sqlList = new List<string>();
                    {
                        string sql = "delete from dbo.Inventory where ProductID = '" + TbProductID.Text + "'";
                        sqlList.Add(sql);
                    }
                    {
                        string sql = "delete from dbo.Products where ProductID = '" + TbProductID.Text + "'";
                        sqlList.Add(sql);
                    }
                    int cnt = GuGuGuHelper.ExecuteNonQueryTransaction(sqlList);
                    if (cnt >= 2) MessageBox.Show("删除成功");
                    else MessageBox.Show("删除失败");
                }
                else
                    MessageBox.Show("该商品已出售或者其他未知错误");
                TextBoxFill();
            }
        }
        private void Query()
        {
            string sql = "select ProductID as '商品号',ProductName as '商品名称',CompanyName as '供应商名',categoryname as '类别名',UnitPrice as '单价',ThrValue as '阈值', Discont as '折扣' from Products Left join Categories on categories.categoryID = Products.CategoryID Left join Suppliers on suppliers.supplierID = products.supplierID where 1 = 1";
            if (TbProductID.Text != "") sql += "and productID like '%" + TbProductID.Text.Trim() + "%'";
            if (TbProductName.Text != "") sql += "and productName like '%" + TbProductName.Text.Trim() + "%'";
            if (CbxCompanyName.SelectedIndex > 0) sql += "and Products.SupplierID = '" + CbxCompanyName.SelectedValue + "'";
            if (CbxCategoryName.SelectedIndex > 0) sql += "and Products.CategoryID = '" + CbxCategoryName.SelectedValue + "'";
            if(TbUnitPrice.Text != "") sql += "and UnitPrice = '" + TbUnitPrice.Text.Trim() + "'";
            if(TbValue.Text != "") sql += "and ThrValue ='" + TbValue.Text.Trim() + "'";
            if(RbOK.Checked) sql += "and Discont = 'true'";
            if (RbNO.Checked) sql += "and Discont = 'false'";
            DGVProduct.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TextBoxEmpty();
            TbProductID.Text = GuGuGuHelper.GetProductID();
            SetEnable(false, true, true, true, true, true, true,"当前操作模式：添加", true, "添加", true, "add");
        }

        private void DataProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TextBoxEmpty();
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProduct))
            {
                TextBoxFill();
                SetEnable(false, false, false, false, false, false, false, "当前操作模式：删除", true, "删除", true, "delete");
            }
        }

        private void DataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProduct) && op != "add")
            {
                TextBoxFill();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ProRefresh();
        }

        private void BtnAlter_Click(object sender, EventArgs e)
        {
            SetEnable(false, true, true, true, true, true, true, "当前操作模式：修改", true, "修改", true, "update");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (op == "query")
            {
                Query();
                return;
            }
            if (op == "add") Insert();
            if (op == "update") Updates();
            if (op == "delete") Delete();
            ProRefresh();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RbOK.Checked = false;
            RbNO.Checked = false;
        }
        private void ProductInfomation_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, false, false, false, "请选择操作模式", false, "确定", false, "other");
        }
    }
}
