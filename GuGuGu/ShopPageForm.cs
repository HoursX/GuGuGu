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
    public partial class ShopPageForm : Form
    {
        readonly string employeeID = null;
        public ShopPageForm(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }
        int selectRow = 0;
        double sum = 0;
        readonly DataTable table = new DataTable();

        private void ShopPageForm_Load(object sender, EventArgs e)
        {
            ShopRefresh();
            DGVProView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVProView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVStock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Add("商品号");
            table.Columns.Add("商品名");
            table.Columns.Add("数量");
            table.Columns.Add("单价");
            table.Columns.Add("折扣");
            TbProID.Enabled = false;
            TbProName.Enabled = false;
            TbUnitPrice.Enabled = false;
            BtnDel.Enabled = false;
        }
        private void DGVProViewFillTextBox()
        {
            TbProID.Text = DGVProView.Rows[selectRow].Cells["商品号"].Value.ToString();
            TbProName.Text = DGVProView.Rows[selectRow].Cells["商品名"].Value.ToString();
            TbUnitPrice.Text = DGVProView.Rows[selectRow].Cells["单价"].Value.ToString();
            if (Convert.ToBoolean(DGVProView.Rows[selectRow].Cells["折扣"].Value))
            {
                TbDiscount.Enabled = true;
            }
            else
            {
                TbDiscount.Enabled = false;
            }

        }
        private void DGVStockFillTextBox()
        {
            TbProID.Text = DGVStock.Rows[selectRow].Cells["商品号"].Value.ToString();
            TbProName.Text = DGVStock.Rows[selectRow].Cells["商品名"].Value.ToString();
            TbUnitPrice.Text = DGVStock.Rows[selectRow].Cells["单价"].Value.ToString();
            TbQuantity.Text = DGVStock.Rows[selectRow].Cells["数量"].Value.ToString();
            TbDiscount.Text = DGVStock.Rows[selectRow].Cells["折扣"].Value.ToString();
        }
        private void ShopRefresh()
        {
            string sql = "select ProductID as '商品号',ProductName as '商品名',UnitPrice as '单价',Description as '描述',Discont as '折扣'from Products";
            DGVProView.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void TextBoxEmpty()
        {
            TbProID.Text = "";
            TbProName.Text = "";
            TbQuantity.Text = "";
            TbDiscount.Text = "";
            TbUnitPrice.Text = "";
        }

        private void DGVProView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            TextBoxEmpty();
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProView))
            {
                DGVProViewFillTextBox();
            }
        }
        private DataRow NewRow()
        {
            try
            {
                DataRow row = table.NewRow();
                row["商品号"] = TbProID.Text.Trim();
                row["商品名"] = TbProName.Text.Trim();
                try
                {
                    if (TbQuantity.Text == "") TbQuantity.Text = "1";
                    else if (Convert.ToInt32(TbQuantity.Text.Trim()) <= 0)
                    {
                        FormatException ex = new FormatException();
                        throw ex;
                    }
                    row["数量"] = TbQuantity.Text.Trim();
                }
                catch (FormatException)
                {
                    throw;
                }
                row["单价"] = TbUnitPrice.Text.Trim();
                if (TbDiscount.Text == "") TbDiscount.Text = "1";
                else if (Convert.ToDouble(TbDiscount.Text.Trim()) <= 0 || Convert.ToDouble(TbDiscount.Text.Trim()) > 1)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                row["折扣"] = TbDiscount.Text.Trim();
                return row;
            }
            catch (FormatException)
            {
                MessageBox.Show("数量格式错误！");
            }
            catch (Exception)
            {
                MessageBox.Show("折扣错误！");
            }
            return null;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProView))
            {
                bool flag = true;
                DGVProViewFillTextBox();
                DataRow row = NewRow();
                for (int i = 0; i < DGVStock.RowCount - 1; i++)
                {
                    if (DGVStock.Rows[i].Cells["商品号"].Value.ToString().Trim() == TbProID.Text.Trim())
                    {
                        flag = false;
                        DGVStock.Rows[i].Cells["数量"].Value = (Convert.ToInt32(DGVStock.Rows[i].Cells["数量"].Value) + Convert.ToInt32(TbQuantity.Text.Trim())).ToString();
                    }
                }
                if(flag) table.Rows.Add(row);
                DGVStock.DataSource = table;
                sum += Convert.ToDouble(TbUnitPrice.Text.Trim()) * Convert.ToDouble(TbDiscount.Text.Trim()) * Convert.ToDouble(TbQuantity.Text.Trim());
                LbSum.Text = sum.ToString();
                BtnDel.Enabled = true;
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select ProductID as '商品号',ProductName as '商品名',UnitPrice as '单价',Description as '描述',Discont as '折扣'from Products where ProductID like'%"+TbSearch.Text.Trim()+"%' or ProductName like'%"+TbSearch.Text.Trim()+"%'";
            DGVProView.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }

        private void TbSearch_Leave(object sender, EventArgs e)
        {
            TbSearch.Text = "请输入商品名或商品号进行搜索";
            ShopRefresh();
        }

        private void TbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            TbSearch.Text = "";
        }
        private string GetRecepit()
        {
            List<string> trans = new List<string>();
            string orderID = GuGuGuHelper.GetOrderID();
            string customerID = GuGuGuHelper.ExecuteScalar("select CustomerID from Customers").ToString();
            string sql = "insert into Orders values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
            sql = string.Format(sql, orderID, customerID, this.employeeID, GuGuGuHelper.GetNowTime(), 0, sum, "--", "--");
            trans.Add(sql);
            for (int i = 0; GuGuGuHelper.IsInDataGridView(i,DGVStock); ++i)
            {
                {
                    sql = string.Format("insert into \"Order Details\" values('{0}','{1}','{2}','{3}','{4}')",
                        orderID,
                        DGVStock.Rows[i].Cells["商品号"].Value.ToString(),
                        DGVStock.Rows[i].Cells["单价"].Value.ToString(),
                        DGVStock.Rows[i].Cells["数量"].Value.ToString(),
                        DGVStock.Rows[i].Cells["折扣"].Value.ToString());
                    trans.Add(sql);
                }
                {
                    sql = string.Format("update Inventory set Quantity = Quantity - '{0}' where ProductID = '{1}'",
                        DGVStock.Rows[i].Cells["数量"].Value.ToString(),
                        DGVStock.Rows[i].Cells["商品号"].Value.ToString());
                    trans.Add(sql);
                }
            }
            int cnt = GuGuGuHelper.ExecuteNonQueryTransaction(trans);
            if (cnt > 0) MessageBox.Show("支付成功！正在打印凭条！");
            else MessageBox.Show("出现错误！");
            DataRow rowPay = table.NewRow();
            rowPay["商品名"] = "总金额";
            rowPay["单价"] = LbSum.Text.Trim();
            table.Rows.Add(rowPay);
            DataRow row = table.NewRow();
            row["商品名"] = "单号";
            row["单价"] = orderID;
            table.Rows.Add(row);
            DGVStock.DataSource = table;
            LbSum.Text = "0";
            return orderID;
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            GuGuGuHelper.DataGridViewToExcel(DGVStock, GetRecepit());
            table.Clear();
            DGVStock.DataSource = table;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (DGVStock.CurrentCell != null) selectRow = DGVStock.CurrentCell.RowIndex;
            else BtnDel.Enabled = false;
            TextBoxEmpty();
            if (GuGuGuHelper.IsInDataGridView(selectRow,DGVStock))
            {
                DGVStockFillTextBox();
                table.Rows.RemoveAt(selectRow);
                DGVStock.DataSource = table;
                sum -= Convert.ToDouble(TbUnitPrice.Text.Trim()) * Convert.ToDouble(TbDiscount.Text.Trim()) * Convert.ToDouble(TbQuantity.Text.Trim());
                LbSum.Text = sum.ToString();
                if (DGVStock.CurrentCell != null)
                {
                    selectRow = DGVStock.CurrentCell.RowIndex;
                    DGVStockFillTextBox();
                }
                else BtnDel.Enabled = false;
            }
            //MessageBox.Show(selectRow.ToString());
            
        }

        private void DGVStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            TextBoxEmpty();
            if (GuGuGuHelper.IsInDataGridView(selectRow,DGVStock))
            {
                DGVStockFillTextBox();
            }
        }

        private void ShopPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ShopPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }

        private void DGVProView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectRow = e.RowIndex;
            TextBoxEmpty();
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVProView))
            {
                DGVProViewFillTextBox();
                BtnAdd.PerformClick();
            }
        }

        private void DGVStock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void DGVStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVStock))
            {
                TextBoxEmpty();
                BtnDel.PerformClick();
            }
        }
    }
}
