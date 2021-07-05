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
        public Login log;
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
                    MessageBox.Show("Thay đổi thành công");
                    log = new Login();
                    log.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại email and username");
                }
            }
            else MessageBox.Show("Mật khẩu mới không khớp\nVui lòng nhập lại");
        }
        bool Check(string email,string username,string password)
        {
            return LoginDAL.Instance.ChangePas(email,username,password);
        }

        private void textBack_Click(object sender, EventArgs e)
        {
            log = new Login();
            this.Hide();
            log.ShowDialog();
        }
    }
}
