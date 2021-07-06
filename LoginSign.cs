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
    public partial class LoginSign : Form
    {
        public Login log;


        public LoginSign()
        {
            InitializeComponent();
        }
       

        private void label2_Click(object sender, EventArgs e)
        {
            log = new Login();
            this.Hide();
            log.ShowDialog();
        }

        private void txbUser_Click(object sender, EventArgs e)
        {
            txbUser.Clear();
        }

        private void txbPass_Click(object sender, EventArgs e)
        {
            txbPass.Clear();
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            txbEmail.Clear();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbName_Click(object sender, EventArgs e)
        {
            txbName.Clear();
        }

        private void btnSign_MouseHover(object sender, EventArgs e)
        {
            btnSign.BackColor = Color.FromArgb(51, 145, 222);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text;
            string password = txbPass.Text;
            string email = txbEmail.Text;
            string name = txbName.Text;// Luu ho va ten day 

            //---Check Email type but just check only 2 type is edu.vn and gmail
            string t1 = "@gm.uit.edu.vn";
            string t2 = "@gmail.com";
            bool check1 = email.Contains(t1);
            bool check2 = email.Contains(t2);
            if (check1 || check2)
            {
                if (!CheckUser(username))
                {
                    CreACC(username, password, email, name);// Tạo account mới 
                }
                else MessageBox.Show("Username đã được sử dụng");
            }
            else MessageBox.Show("Kiểm tra lại email\nSử dụng tài khoản @gm.uit.edu.vn hoặc @gmail.com");

        }
        bool CheckUser(string username)
        {
            return LoginDAL.Instance.checkAccbyUser(username);
        }
        void CreACC(string username,string password,string email,string name)
        {
            if (Accounts.Instance.InsertAcc(username, password, email, name))
                MessageBox.Show("Đăng ký thành công");
            else 
                MessageBox.Show("Đăng ký không thành công\nVui lòng kiểm tra lại thông tin cá nhân");

        }

        private void btnSign_MouseLeave(object sender, EventArgs e)
        {
            btnSign.BackColor = Color.FromArgb(0, 117, 214);
        }
    }
}
