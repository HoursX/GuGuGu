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
    public partial class Inventory : Form
    {
        private string op = null;
        private int selectRow = 0;
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            InvReFresh();
            DGVInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInventory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVInventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetEnable(false, false, false, false, false, "请选择操作模式", false, "确定", "other", false);
        }

        private void Query()
        {
            string sql = "select Inventory.ProductID as '商品编号',ProductName as '商品名称',CategoryID as'供应商编号',Quantity as '库存',ThrValue as '阈值' from Products left join Inventory on Products.ProductID=Inventory.ProductID where 1=1";
            if (TbProID.Text != "")
            {
                sql += " and Inventory.ProductID like'%" + TbProID.Text.Trim() + "%'";
            }
            if (TbProName.Text != "")
            {
                sql += " and ProductName like'%" + TbProName.Text.Trim() + "%'";
            }
            if (TbSupID.Text != "")
            {
                sql += " and CategoryID like'%" + TbSupID.Text.Trim() + "%'";
            }
            DGVInventory.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private new void Update()
        {
            string sql = string.Format("update Products set ThrValue = '{0}' where ProductID = '{1}'", TbThrValue.Text.Trim(), TbProID.Text.Trim());
            int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
            if (cnt >= 1) MessageBox.Show("修改成功");
            else MessageBox.Show("修改失败");
        }
        private void InvReFresh()
        {
            string sql = "select Inventory.ProductID as '商品编号',ProductName as '商品名称',CategoryID as'供应商编号',Quantity as '库存',ThrValue as '阈值' from Products left join Inventory on Products.ProductID=Inventory.ProductID";
            DGVInventory.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void TextBoxFill()
        {
            TbProID.Text = DGVInventory.Rows[selectRow].Cells["商品编号"].Value.ToString();
            TbProName.Text = DGVInventory.Rows[selectRow].Cells["商品名称"].Value.ToString();
            TbSupID.Text = DGVInventory.Rows[selectRow].Cells["供应商编号"].Value.ToString();
            TbQuantity.Text = DGVInventory.Rows[selectRow].Cells["库存"].Value.ToString();
            TbThrValue.Text = DGVInventory.Rows[selectRow].Cells["阈值"].Value.ToString();
        }
        private void TextBoxEmpty()
        {
            TbProID.Text = "";
            TbProName.Text = "";
            TbSupID.Text = "";
            TbQuantity.Text = "";
            TbThrValue.Text = "";
        }
        private void SetEnable(bool id, bool name, bool supID, bool quantity, bool thrValue, string lbTip, bool btnEnable, string btnOK, string op, bool exitOp)
        {
            TbProID.Enabled = id;
            TbProName.Enabled = name;
            TbSupID.Enabled = supID;
            TbQuantity.Enabled = quantity;
            TbThrValue.Enabled = thrValue;
            LbTip.Text = lbTip;
            BtnOK.Enabled = btnEnable;
            BtnOK.Text = btnOK;
            this.op = op;
            BtnExit.Enabled = exitOp;
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }

        private void DGVInventory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            for (int i = 0; GuGuGuHelper.IsInDataGridView(i, DGVInventory); ++i)
            {
                int quantity = Convert.ToInt32(DGVInventory.Rows[i].Cells["库存"].Value);
                int thrValue = Convert.ToInt32(DGVInventory.Rows[i].Cells["阈值"].Value);

                if (quantity < thrValue)
                {
                    DGVInventory.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void BtnQue_Click(object sender, EventArgs e)
        {
            SetEnable(true, true, true, false, false, "当前操作模式：查询", true, "查询", "query", true);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (op == "query")
            {
                Query();
                return;
            }
            if (op == "update") Update();
            InvReFresh();
        }

        private void DGVInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if (GuGuGuHelper.IsInDataGridView(selectRow, DGVInventory))
            {
                TextBoxFill();
            }
            else TextBoxEmpty();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, false, "请选择操作模式", false, "确定", "other", false);
            GuGuGuHelper.DataGridViewToExcel(DGVInventory, GuGuGuHelper.GetFileName("Inventory"));
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, true, "当前操作模式：商品阈值设置", true, "修改", "update", true);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            InvReFresh();
        }

        private void BtnAlert_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, false, "当前操作模式：商品告急目录", false, "确定", "other", false);
            string sql = "select Inventory.ProductID as '商品编号',ProductName as '商品名称',CategoryID as'供应商编号',Quantity as '库存',ThrValue as '阈值' from Products left join Inventory on Products.ProductID=Inventory.ProductID where Products.ThrValue > Inventory.Quantity";
            DGVInventory.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
            TextBoxEmpty();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SetEnable(false, false, false, false, false, "请选择操作模式", false, "确认", "other", false);
        }
    }
}
