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
    public partial class ProductGategory : Form
    {
        string op = null;
        int selectRow = 0;
        public ProductGategory()
        {
            InitializeComponent();
        }
        private void CateRefresh()
        {
            string sql = "select CategoryID as '商品类别编号',CategoryName as '类别名',Description as '类别描述' from Categories";
            DGVCategories.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void ProductGategory_Load(object sender, EventArgs e)
        {
            CateRefresh();
            DGVCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategories.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TbDe.Enabled = false;
            TbID.Enabled = false;
            TbName.Enabled = false;
            BtnOk.Enabled = false;
        }

        private void DGVCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddCategories_Click(object sender, EventArgs e)
        {
            TbDe.Enabled = true;
            TbID.Enabled = false;
            TbName.Enabled = true;
            BtnOk.Enabled = true;
            BtnOk.Text = "添加";
            op = "add";
            LbTip.Text = "当前操作模式：添加";
            TextBoxEmpty();
            TbID.Text = GuGuGuHelper.GetCategoryID();
        }
        
        private void Query()
        {
            string sql = "select CategoryID as '商品类别编号',CategoryName as '类别名',Description as '类别描述' from Categories where 1 = 1";
            if (TbID.Text != "")
            {
                sql += " and CategoryID like'%" + TbID.Text.Trim() + "%'";
            }
            if (TbName.Text != "")
            {
                sql += " and CategoryName like'%" + TbName.Text.Trim() + "%'";
            }
            if (TbDe.Text != "")
            {
                sql += " and Description like'%" + TbDe.Text.Trim() + "%'";
            }
            //MessageBox.Show(sql);
            DGVCategories.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void Insert()
        {
            string sql = string.Format("insert into Categories values('{0}','{1}','{2}')", TbID.Text.Trim(), TbName.Text.Trim(), TbDe.Text);
            int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
            if (cnt >= 1) MessageBox.Show("插入成功");
            else MessageBox.Show("插入失败");
            TbID.Text = GuGuGuHelper.GetCategoryID();
            CateRefresh();
        }
        private void Delete()
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVCategories))
            {
                string id = DGVCategories.Rows[selectRow].Cells["商品类别编号"].Value.ToString();
                {
                    string sql = "select * from Products where CategoryID = " + id + "'";
                    if (GuGuGuHelper.ExcuteExist(sql))
                    {
                        MessageBox.Show("该类别下含有商品，禁止删除！");
                        return;
                    }
                }
                {
                    string sql = "delete from Categories where CategoryID = '" + id + "'";
                    int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
                    if (cnt >= 1) MessageBox.Show("删除成功");
                    else MessageBox.Show("删除失败");
                    CateRefresh();
                }
            }
            else
            {
                MessageBox.Show("请选择正确的行");
            }
        }
        private void Updates()
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVCategories))
            {
                string id = DGVCategories.Rows[selectRow].Cells["商品类别编号"].Value.ToString();
                string sql = "update Categories set CategoryName = '" + TbName.Text.Trim() + "',Description = '" + TbDe.Text.Trim() + "' where CategoryID = '" + id + "'";
                int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
                if (cnt >= 1) MessageBox.Show("更新成功");
                else MessageBox.Show("更新失败");
                CateRefresh();
            }
            else
            {
                MessageBox.Show("请选择正确的行");
            }
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (op == "add")    Insert();
            if (op == "query")  Query();
            if (op == "delete") Delete();
            if (op == "update") Updates();

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CateRefresh();
        }

        private void BtnUpdCategories_Click(object sender, EventArgs e)
        {
            if(GuGuGuHelper.IsInDataGridView(selectRow,DGVCategories))
            {
                TextBoxFill();
            }
            TextBoxEmpty();
            op = "update";
            TbDe.Enabled = true;
            TbID.Enabled = false;
            TbName.Enabled = true;
            BtnOk.Enabled = true;
            LbTip.Text = "当前操作模式：更新";
            BtnOk.Text = "更新";
        }

        private void BtnQueCategories_Click(object sender, EventArgs e)
        {
            op = "query";
            TbDe.Enabled = true;
            TbID.Enabled = true;
            TbName.Enabled = true;
            BtnOk.Enabled = true;
            LbTip.Text = "当前操作模式：查询";
            BtnOk.Text = "查询";
        }
        private void TextBoxFill()
        {
            TbDe.Text = DGVCategories.Rows[selectRow].Cells["类别描述"].Value.ToString();
            TbID.Text = DGVCategories.Rows[selectRow].Cells["商品类别编号"].Value.ToString();
            TbName.Text = DGVCategories.Rows[selectRow].Cells["类别名"].Value.ToString();
        }
        private void TextBoxEmpty()
        {
            TbDe.Text = "";
            TbID.Text = "";
            TbName.Text = "";
        }
        private void BtnDelCategories_Click(object sender, EventArgs e)
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow,DGVCategories))
            {
                op = "delete";
                TextBoxFill();
                TbDe.Enabled = false;
                TbID.Enabled = false;
                TbName.Enabled = false;
                BtnOk.Enabled = true;
                BtnOk.Text = "确认删除";
                LbTip.Text = "当前操作模式：删除";
            }
            else
            {
                MessageBox.Show("请选择正确的行");
            }
        }


        private void DGVCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if(GuGuGuHelper.IsInDataGridView(selectRow,DGVCategories))
            {
                if (op == "delete" || op == "update")
                {
                    TextBoxFill();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            TextBoxEmpty();
            TbDe.Enabled = false;
            TbID.Enabled = false;
            TbName.Enabled = false;
            BtnOk.Enabled = false;
            LbTip.Text = "请选择操作模式";
            BtnOk.Text = "确定";
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            GuGuGuHelper.DataGridViewToExcel(DGVCategories,GuGuGuHelper.GetNowTime());
        }

        private void ProductGategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }
    }
}
