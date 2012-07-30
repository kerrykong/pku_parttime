using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
using HR.DataClass;

namespace HR
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                textPass.Focus();

        }

        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                butLogin.Focus();
                butLogin.PerformClick();
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" & textPass.Text != "")
            {
                SQLiteDataReader dr = DBConnect.getDataReader("select * from sys_user where name='" + textName.Text.Trim() + "' and password='" + textPass.Text.Trim() + "';");
                bool ifdr = dr.Read();
                if (ifdr)
                {
                    DBConnect.Login_Name = textName.Text.Trim();
               //     DBConnect.Login_ID = dr.GetValue(0).ToString();
                    DBConnect.closeCon();
                    MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Text = "";
                    textPass.Text = "";
                }
                DBConnect.closeCon();
            }
            else
                MessageBox.Show("请将登录信息填写完整!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
