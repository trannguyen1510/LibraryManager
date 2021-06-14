using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace LibraryManager
{
    public partial class Muon : Form
    {
        DBConnect db = new DBConnect();
        public Muon()
        {
            InitializeComponent();

         
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textmasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            DataTable task;
            string maso = textmasach.Text;
            if (string.IsNullOrWhiteSpace(maso) )
            {
                MessageBox.Show("vui lòng nhập mã số");
            }
            else
            {
                string query = "SELECT * FROM BOOK where ID = " + maso;
                task = db.GetDataTable(query);
                if (task != null)
                {
                    
                        texttensach.Text = task.Rows[0][1].ToString();
                        comboBox1.Text = task.Rows[0][2].ToString();
                        texttacgia.Text = task.Rows[0][3].ToString();                    
                    
                }
                else
                {
                    MessageBox.Show("Nhap sai");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            DataTable temp;
            string id = textBox3.Text;// lay ma doc gia
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("vui lòng nhập mã số");
                }
                else
                {
                    string query = "SELECT * FROM READER where ID = " + id;
                    temp = db.GetDataTable(query);
                    if (temp != null)
                    {

                        textBox2.Text = temp.Rows[0][1].ToString();//họ tên
                        textBox5.Text = temp.Rows[0][4].ToString();//Email
                    }
                    else
                    {
                        MessageBox.Show("Nhap sai");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                throw new Exception(ex.Message);
            }           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
