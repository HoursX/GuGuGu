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
    public partial class GuGuGu : Form
    {
        string activeUser;
        string activeUserName;
        string dd = DateTime.Now.ToString("ddd", new System.Globalization.CultureInfo("zh-cn"));
        public static bool checkClose = false;
        public static int formID = 0;
        private Form fm = null;
        
        public GuGuGu(string activeUser)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.activeUser = activeUser;
        }

        private void Control_Click(object sender, EventArgs e)
        {

        }
        private void LoadView()
        {
            ActiveUser.Text = "当前工号:[" + activeUser + "]";
            string sql = "select Name from Employees where EmployeeID = '" + activeUser + "'";
            activeUserName = GuGuGuHelper.ExecuteScalar(sql).ToString();
            ActiveUserName.Text = "姓名:" + activeUserName;
            string tip = "您好！";
            int hh = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (hh >= 6 && hh <= 8) tip = "早上好！";
            else if (hh >= 9 && hh < 12) tip = "上午好！";
            else if (hh >= 12 && hh < 14) tip = "中午好！";
            else if (hh >= 14 && hh < 19) tip = "下午好！";
            else if (hh >= 19 && hh < 24) tip = "晚上好！";
            LogoTip.Text = activeUserName +"，"+ tip;
        }
        private void GuGuGu_Load(object sender, EventArgs e)
        {
            LoadView();
            InfoView();
        }
        private void InfoView()
        {
            string sql = "select Inventory.ProductID as '商品编号',ProductName as '商品名称' from Products left join Inventory on Products.ProductID=Inventory.ProductID where Products.ThrValue > Inventory.Quantity";
            if (!GuGuGuHelper.ExcuteExist(sql))
            {
                LbInfo.Text = "商品告急信息：当前暂无商品缺货";
                LbProTip.Text = "";
                return;
            }
            else
            {
                LbProTip.Text = "";
                LbInfo.Text = "商品告急信息：以下商品库存紧急，详细信息请到”库存信息 > 商品库存查询“处查看";
            }
            
            {
                DataTable table = GuGuGuHelper.ExecuteReaderDataTable(sql);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    LbProTip.Text += "商品编号："+table.Rows[i]["商品编号"].ToString() +" 商品名称："+ table.Rows[i]["商品名称"].ToString() + "\r\n\r\n";
                }
            }
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OpenForm(int formid)
        {
            switch (formid)
            {
                case 0:
                    {
                        MainPanel.Visible = true;
                        break;
                    }
                case 1:
                    {
                        fm = new ShopPageForm(activeUser);
                        Start();
                        break;
                    }
                case 2:
                    {
                        fm = new ProductInfomation();
                        Start();
                        break;
                    }
                case 3:
                    {
                        fm = new ProductGategory();
                        Start();
                        break;
                    }
                case 4:
                    {
                        fm = new SaleTicketForm();
                        Start();
                        break;
                    }
                case 5:
                    {
                        fm = new Inventory();
                        Start();
                        break;
                    }
                case 6:
                    {
                        fm = new StockForm();
                        Start();
                        break;
                    }
                case 7:
                    {
                        fm = new CustomerMaintain();
                        Start();
                        break;
                    }
                case 8:
                    {
                        fm = new UserFrom(activeUser);
                        Start();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("页面出错！");
                        break;
                    }
            }
            formID = formid;
        }
        private void CloseForm(int formid)
        {
            fm.Close();
            checkClose = false;
        }
        private void ChangeForm(int nextFormID)
        {
            if (checkClose && formID == nextFormID) return;
            if (checkClose)
            {
                CloseForm(formID);
                OpenForm(nextFormID);
                return;
            }
            OpenForm(nextFormID);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ChangeForm(1);

        }
        private void Start()
        {
            MainPanel.Visible = false;
            
            fm.MdiParent = this;
            fm.Show();
            checkClose = true;
        }
        private void BtnCustomerData_Click(object sender, EventArgs e)
        {
            ChangeForm(7);
        }

        private void CustomerData_Click(object sender, EventArgs e)
        {
            ChangeForm(7);
        }

        private void ShopPage_Click(object sender, EventArgs e)
        {
            ChangeForm(1);
        }

        private void TimerSetTime_Tick(object sender, EventArgs e)
        {
            Time.Text = "当前时间:" + GuGuGuHelper.GetNowTime();
            LbTime.Text = "时间:" + GuGuGuHelper.GetNowTime() + " " + dd;
            
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            ChangeForm(0);
        }

        private void TimerPanelVisible_Tick(object sender, EventArgs e)
        {
            if (!checkClose)
            {
                MainPanel.Visible = true;
                //MessageBox.Show("jianch3");
            }
            InfoView();
        }

        private void BtnProductGategory_Click(object sender, EventArgs e)
        {
            ChangeForm(3);
        }

        private void ProductCategoryMaintain_Click(object sender, EventArgs e)
        {
            ChangeForm(3);
        }

        private void BtnInventoryInfo_Click(object sender, EventArgs e)
        {
            ChangeForm(5);
        }

        private void BtnSaleTicket_Click(object sender, EventArgs e)
        {
            ChangeForm(4);
        }

        private void SaleTicketQuery_Click(object sender, EventArgs e)
        {
            ChangeForm(4);
        }

        private void InventoryInfoQuery_Click(object sender, EventArgs e)
        {
            ChangeForm(5);
        }

        private void BtnProductStock_Click(object sender, EventArgs e)
        {
            ChangeForm(6);
        }

        private void ProductStock_Click(object sender, EventArgs e)
        {
            ChangeForm(6);
        }

        private void BtnProductData_Click(object sender, EventArgs e)
        {
            ChangeForm(2);
        }

        private void ProductDataMaintain_Click(object sender, EventArgs e)
        {
            ChangeForm(2);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            ChangeForm(8);
        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            ChangeForm(8);
        }
    }
}
