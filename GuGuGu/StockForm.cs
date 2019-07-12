using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuGuGu
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        private void Btnlead_Click(object sender, EventArgs e)
        {
            GuGuGuHelper.ExcelToDataGridView(this.DGVDataStock); 
        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < DGVDataStock.Rows.Count - 1; i++)
            {

                string sql = "Update Inventory set Quantity = '" + DGVDataStock.Rows[i].Cells["商品数量"].Value.ToString() + "'" + "+Quantity where productID = '" + DGVDataStock.Rows[i].Cells["商品编号"].Value.ToString() + "'";
                list.Add(sql);
            }
            int d = GuGuGuHelper.ExecuteNonQueryTransaction(list);
            if (d == DGVDataStock.Rows.Count - 1)
            {
                MessageBox.Show("数据写入成功");
                StockReFresh();
            }
            else
                MessageBox.Show("数据写入失败");
        }
        private void StockReFresh()
        {
            string sql = "select Inventory.ProductID as '商品编号',ProductName as '商品名称',CategoryID as'供应商编号',Quantity as '库存' from Products left join Inventory on Products.ProductID=Inventory.ProductID";
            DGVInventory.DataSource = GuGuGuHelper.ExecuteReaderDataTable(sql);
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            StockReFresh();
            DGVInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInventory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVInventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVDataStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVDataStock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVDataStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Stock_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }

        private void BtnReFresh_Click(object sender, EventArgs e)
        {
            StockReFresh();
        }
    }
}
