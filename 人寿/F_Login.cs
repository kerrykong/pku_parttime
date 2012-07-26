using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 人寿
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
                butLogin.Focus();
        }

    }
}
