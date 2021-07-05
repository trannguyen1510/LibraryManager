using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace LibraryManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static Accounts GetAccount()
        {
            Login loginForm = new Login();
            Application.Run(loginForm);
            return loginForm.loginAcc;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Accounts loginAcc = GetAccount();
            if (loginAcc != null)
            {
                Main main = new Main(loginAcc);
                Application.Run(main);
            }
            else
                MessageBox.Show("Đăng nhập thất bại");
        }
    }
}
