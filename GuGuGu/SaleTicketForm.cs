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
    public partial class SaleTicketForm : Form
    {
        int selectRow = 0;
        public SaleTicketForm()
        {
            InitializeComponent();
        }
        private void OrderRefresh()
        {
            string sql = "select OrderID as '订单号',CustomerID as '顾客号',EmployeeID as '员工号',OrderDate as '订单日期',Freight as '配送费',ToTalPrice as '总金额',ShipName as '配送商',ShipAddress as '配送地址' from Orders";
            DGVOrder.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void OrderDetailsRefresh()
        {
            string sql = string.Format("select Products.ProductID as '商品编号', Products.ProductName as '商品名',\"Order Details\".UnitPrice as '单价',Quantity as '数量',Discount as '折扣' from \"Order Details\" join Products on Products.ProductID = \"Order Details\".ProductID where OrderID = '{0}'", DGVOrder.Rows[selectRow].Cells["订单号"].Value.ToString());
            DGVOrderDetails.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void SaleTicketForm_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            DGVOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVOrder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVOrderDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVOrderDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OrderRefresh();
            OrderDetailsRefresh();
            LbTip.Text = "当前订单号：" + DGVOrder.Rows[selectRow].Cells["订单号"].Value.ToString();
        }
        private void Search()
        {
            string sql = "select OrderID as '订单号',CustomerID as '顾客号',EmployeeID as '员工号',OrderDate as '订单日期',Freight as '配送费',ToTalPrice as '总金额',ShipName as '配送商',ShipAddress as '配送地址' from Orders where 1 = 1";
            if (TbOrdID.Text.Trim() != "")
            {
                sql += " and OrderID like '%" + TbOrdID.Text.Trim() + "%'";
            }
            if (TimePickerEnd.Value.Date >= TimePickerStart.Value.Date)
            {
                //MessageBox.Show(TimePickerStart.Value.Date.ToString("yyyy-MM-dd"));
                //MessageBox.Show(TimePickerEnd.Value.Date.ToString("yyyy-MM-dd"));
                sql += " and OrderDate >= '" + TimePickerStart.Value.Date.ToString("yyyy-MM-dd") + "' and OrderDate <= '" + TimePickerEnd.Value.Date.ToString("yyyy-MM-dd") +"'";
            }
            if(TbCusID.Text.Trim() != "")
            {
                sql += " and CustomerID like%'" + TbCusID.Text.Trim() + "%'";
            }
            //MessageBox.Show(sql);
            DGVOrder.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void DGVOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVOrder))
            {
                LbTip.Text = "当前订单号：" + DGVOrder.Rows[selectRow].Cells["订单号"].Value.ToString();
                OrderDetailsRefresh();
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            GuGuGuHelper.DataGridViewToExcel(DGVOrder, GuGuGuHelper.GetFileName("SaleTicket"));
        }

        private void TimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            if (TimePickerEnd.Value.Date < TimePickerStart.Value.Date)
            {
                MessageBox.Show("时间间隔错误");
                return;
            }
            Search();
        }

        private void TimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (TimePickerEnd.Value.Date < TimePickerStart.Value.Date)
            {
                MessageBox.Show("时间间隔错误");
                return;
            }
            Search();
        }

        private void TbOrdID_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TbCusID_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void SaleTicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }
    }
}
