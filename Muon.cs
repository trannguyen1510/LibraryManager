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
    public partial class Muon : Form
    {
        DBConnect db;
        public Muon()
        {
            InitializeComponent();

            db = new DBConnect();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void masach_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thongtinsach_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ngaytra_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            textmasach.Text = "ket qua tra ve";
        }

        private void trangchu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
            this.Show();

        }
    }

}