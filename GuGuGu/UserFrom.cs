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
    public partial class UserFrom : Form
    {
        private string activeUser;
        public UserFrom(string activeUser)
        {
            this.activeUser = activeUser;
            InitializeComponent();
        }
        private void BtnChangePassWord_Click(object sender, EventArgs e)
        {
            if (TbxNewPassword.Text.Trim() == "" || TbxPassWord.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！！");
                return;
            }
            if (TbxPassWord.Text.Trim() == TbxNewPassword.Text.Trim())
            {
                string sql = "Update Login set Password = '{0}' where EmployeeID = '" + TbxEmployeeID.Text.Trim() + "'";
                sql = string.Format(sql, this.TbxNewPassword.Text);
                int cnt = GuGuGuHelper.ExecuteNonQuery(sql);
                if (cnt >= 1)
                    MessageBox.Show("修改成功");
                else
                    MessageBox.Show("修改失败");
            }
            else
                MessageBox.Show("两次输入的密码不一致，请重新输入"); 
        }

        private void UserFrom_Load(object sender, EventArgs e)
        {
            TbxEmployeeID.Enabled = false;
            this.TbxEmployeeID.Text = activeUser;
        }

        private void UserFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuGuGu.checkClose = false;
        }
    }
}
