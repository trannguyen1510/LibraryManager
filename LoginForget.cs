using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class LoginForget : Form
    {
        public LoginForget()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtbEmail.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtbUser.Clear();

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txtbNewPass.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            txtbNewPass2.Clear();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            string email = txtbEmail.Text;
            string username = txtbUser.Text;
            string pass1 = txtbNewPass.Text;
            string pass2 = txtbNewPass2.Text;
            if (pass1 == pass2)
            {
                if (Check(email, username, pass1))
                {
                    MessageBox.Show("Change Succeed");
                    Login lg = new Login();
                    lg.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("pls check email and username");
                }
            }
            else MessageBox.Show("Pls check your new password again");
        }
        bool Check(string email,string username,string password)
        {
            return LoginDAL.Instance.ChangePas(email,username,password);
        }
    }
}
