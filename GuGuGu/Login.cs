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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TbUserName.Text.Trim() == "" || TbPWS.Text.Trim() == "")
            {
                MessageBox.Show("请正确输入账号和密码");
                return;
            }
            List<SqlParameter> sqlList = new List<SqlParameter>()
            {
                GuGuGuHelper.CreatePara("@EmployeeID",SqlDbType.Char,ParameterDirection.Input,TbUserName.Text.Trim(),10),
                GuGuGuHelper.CreatePara("@password", SqlDbType.Char,ParameterDirection.Input,TbPWS.Text.Trim(),16),
                GuGuGuHelper.CreatePara("@returnValue", SqlDbType.Int,ParameterDirection.ReturnValue),
            };
            GuGuGuHelper.ExecuteNonQuery("prcLogin", sqlList, CommandType.StoredProcedure);
            int returnValue = Convert.ToInt32(sqlList.ElementAt(2).Value);
            if (returnValue == 1)
            {
                MessageBox.Show("登陆成功!");
                GuGuGu fm = new GuGuGu(TbUserName.Text.Trim());
                Hide();
                fm.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("登陆失败!");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
        }
    