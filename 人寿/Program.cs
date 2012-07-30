using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using HR.DataClass;

namespace HR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
/*            SysUser usr = new SysUser("liyue", "123");
            if (AddUser.Create(usr))
            {
                MessageBox.Show("Add user liyue!!!");
            }
  */          Application.Run(new F_Login());
        }
    }
}
