﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)// nút thoát
        {
            Application.Exit();
        }

       

        private void button2_Click(object sender, EventArgs e)  // chuyển đến form đổi mật khẩu
        {
            LoginForget fforget = new LoginForget();
            this.Hide();
            fforget.ShowDialog();
        }
        private void btnSign_Click(object sender, EventArgs e) //chuyển đến form                                                         đăng ký
        {
            LoginSign sign = new LoginSign();
            this.Hide();
            sign.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)  
        {
            
            string username = TbUserName.Text.Trim();
            string pass = TbPassword.Text;
            if (LoginUser(username, pass))
            {
                Accounts loginAcc = LoginDAL.Instance.GetAcccoutbyUser(username);
                Main fmain = new Main(loginAcc);
                this.Hide();
                fmain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khaair sai\nVui lòng nhập lại");
            }
        }
        bool LoginUser(string username, string password) //  hàm kiểm tra gọi từ class xử lý đăng nhập 
        {                                           
            return LoginDAL.Instance.Login(username, password);
        }
   //----------------Effect Degin UI----------------------------------------------
        private void TbUserName_Click(object sender, EventArgs e)
        {
            TbUserName.Clear();
        }

        private void TbPassword_Click(object sender, EventArgs e)
        {
            TbPassword.Clear();
        }

        private void btnEnter_MouseHover(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.FromArgb(51, 145, 222);
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.FromArgb(0, 117, 214);
        }

        private void btnForget_MouseHover(object sender, EventArgs e)
        {
            btnForget.BackColor = Color.FromArgb(51, 145, 222);
        }

        private void btnForget_MouseLeave(object sender, EventArgs e)
        {
            btnForget.BackColor = Color.FromArgb(0, 117, 214);
        }

        private void btnSign_MouseHover(object sender, EventArgs e)
        {
            btnSign.BackColor = Color.FromArgb(51, 145, 222);
        }

        private void btnSign_MouseLeave(object sender, EventArgs e)
        {
            btnSign.BackColor = Color.FromArgb(0, 117, 214);
        }
    }
}
