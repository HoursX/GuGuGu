using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuGuGu
{
    public partial class CustomerMaintain : Form
    {
        int selectRow = 0;
        string op = null;
        public CustomerMaintain()
        {
            InitializeComponent();
        }

        private void Customermaintain_Load(object sender, EventArgs e)
        {
            ProRefresh();
            SetEnable(false, false, false, false, false, false, "请选择操作模式", false, "确定", "other", false);
            CustomerMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerMain.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CustomerMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void Search()
        {
            string sql = "select CustomerID as '客户编号',CustomerName as '客户名',Address as'地址',Phone as '电话',Credits as '积分',Notes as '客户类别' from Customers where 1=1";
            if (TbCustomerID.Text != "") sql += " and CustomerID like'%" + TbCustomerID.Text.Trim() + "%'";
            if (TbCustomerName.Text != "") sql += " and CustomerName like'%" + TbCustomerName.Text.Trim() + "%'";
            if (TbCustomerAddr.Text != "") sql += " and Address like'%" + TbCustomerAddr.Text.Trim() + "%'";
            if (TbCustomerTel.Text != "") sql += " and Phone like'%" + TbCustomerTel.Text.Trim() + "%'";
            if (TbCustomerCre.Text != "") sql += " and Credits like'%" + TbCustomerCre.Text.Trim() + "%'";
            if (TbCustomerNote.Text != "") sql += " and Notes like'%" + TbCustomerNote.Text.Trim() + "%'";
            CustomerMain.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void Insert()
        {
            string sql = @"INSERT INTO dbo.Customers VALUES( '{0}','{1}','{2}','{3}','{4}','{5}')";
            sql = string.Format(sql, TbCustomerID.Text.Trim(), TbCustomerName.Text.Trim(), TbCustomerAddr.Text.Trim(), TbCustomerTel.Text.Trim(), TbCustomerCre.Text.Trim(), TbCustomerNote.Text.Trim());
            int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
            MessageBox.Show((cnt >= 1) ? "添加成功" : "添加失败");
        }
        private void Updates()
        {
            string sql = @"update dbo.Customers set CustomerName='{0}',Address='{1}',Phone='{2}',Credits='{3}',Notes='{4}' where CustomerID='{5}'";
            sql = string.Format(sql, TbCustomerID.Text.Trim(), TbCustomerName.Text.Trim(), TbCustomerAddr.Text.Trim(), TbCustomerTel.Text.Trim(), TbCustomerCre.Text.Trim(), TbCustomerNote.Text.Trim());
            int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
            MessageBox.Show((cnt >= 1) ? "修改成功" : "修改失败");
        }
        private void Delete()
        {
            if (GuGuGuHelper.IsInDataGridView(selectRow, CustomerMain))
            {
                string id = CustomerMain.Rows[selectRow].Cells["客户编号"].Value.ToString();
                string sql = "delete from Customers where CustomerID = '" + id + "'";
                int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
                if (cnt >= 1) MessageBox.Show("删除成功");
                else MessageBox.Show("删除失败，该用户存在订单或者其他未知错误");
            }
            else
            {
                MessageBox.Show("请选择正确的行");
            }
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (op == "query")
            {
                Search();
                return;
            }
            if (op == "add") Insert();
            if (op == "update") Updates();
            if (op == "delete") Delete();
            ProRefresh();
        }

        private void TextBoxFill()
        {
            TbCustomerID.Text = CustomerMain.Rows[selectRow].Cells["客户编号"].Value.ToString();
            TbCustomerName.Text = CustomerMain.Rows[selectRow].Cells["客户名"].Value.ToString();
            TbCustomerAddr.Text = CustomerMain.Rows[selectRow].Cells["地址"].Value.ToString();
            TbCustomerTel.Text = CustomerMain.Rows[selectRow].Cells["电话"].Value.ToString();
            TbCustomerCre.Text = CustomerMain.Rows[selectRow].Cells["积分"].Value.ToString();
            TbCustomerNote.Text = CustomerMain.Rows[selectRow].Cells["客户类别"].Value.ToString();
        }
        private void TextBoxEmpty()
        {
            TbCustomerID.Text = "";
            TbCustomerName.Text = "";
            TbCustomerAddr.Text = "";
            TbCustomerTel.Text = "";
            TbCustomerCre.Text = "";
            TbCustomerNote.Text = "";
        }

        private void CustomerMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ProRefresh()
        {
            string sql = "select CustomerID as '客户编号',CustomerName as '客户名',Address as'地址',Phone as '电话',Credits as '积分',Notes as '客户类别' from Customers ";
            CustomerMain.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }

        private void CustomerMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if(GuGuGuHelper.IsInDataGridView(selectRow,CustomerMain) && op != "add")
            {
                TextBoxEmpty();
                TextBoxFill();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customermaintain_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }
        private void SetEnable(bool tbCustomerID, bool tbCustomerName, bool tbCustomerAddr, bool tbCustomerTel, bool tbCustomerCre, bool tbCustomerNote, string lbTip, bool btnEnable, string btnOk, string op, bool exitOp)
        {
            TbCustomerID.Enabled = tbCustomerID;
            TbCustomerName.Enabled = tbCustomerName;
            TbCustomerAddr.Enabled = tbCustomerAddr;
            TbCustomerTel.Enabled = tbCustomerTel;
            TbCustomerCre.Enabled = tbCustomerCre;
            TbCustomerNote.Enabled = tbCustomerNote;
            LbTip.Text = lbTip;
            BtnOk.Text = btnOk;
            BtnOk.Enabled = btnEnable;
            this.op = op;
            BtnExit.Enabled = exitOp;
        }
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            SetEnable(false, true, true, true, false, true, "当前操作模式：添加", true, "添加", "add", true);
            TextBoxEmpty();
            TbCustomerID.Text = GuGuGuHelper.GetCustomerID();
            TbCustomerCre.Text = "0";
        }

        private void BtnDelCustomer_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, false, false, "当前操作模式：删除", true, "删除", "delete", true);
        }

        private void BtnUpdCustomer_Click(object sender, EventArgs e)
        {
            SetEnable(false, true, true, true, false, true, "当前操作模式：更新", true, "更新", "update", true);
        }

        private void BtnQueCustomer_Click(object sender, EventArgs e)
        {
            SetEnable(true, true, true, true, true, true, "当前操作模式：查询", true, "查询", "query", true);
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            GuGuGuHelper.DataGridViewToExcel(CustomerMain, GuGuGuHelper.GetFileName("Customers"));
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ProRefresh();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, false, false, "请选择操作模式", false, "确定", "other", false);
        }
    }
}

