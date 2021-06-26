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
    public partial class Muon_Tra : Form
    {
        public Muon_Tra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nhap ma sinh vien--> Hien thi ra thong tin sinh vien vaf cac cuon sach da muon

            //Ho va ten 
            //Dia chi
            //Email
            //MSSV
            //Ngay sinh

            DBConnect db = new DBConnect();
            DataTable Table;
            DataTable Data;
            string id = textBox1.Text;// lay ma doc gia
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("vui lòng nhập mã số");
                }
                else
                { 
                    string query = "SELECT * FROM READER where ID = " + id;
                    string query2 = "SELECT * from BOOK_BORROW where UserID = " + id;
                    Table = db.GetDataTable(query);
                    Data = db.GetDataTable(query2);
                    if (Table != null)
                    {
                        //HIen thi thong tin sinh vien
                        textBox4.Text = Table.Rows[0][0].ToString();  //MSSV             
                        textBox2.Text = Table.Rows[0][1].ToString();  //Ho va ten
                        textBox6.Text = Table.Rows[0][2].ToString();  //Ngay sinh
                        textBox5.Text = Table.Rows[0][3].ToString();  //Dia chi
                        textBox3.Text = Table.Rows[0][4].ToString();  //Email
                        //Hien thi thong tin muon sach sinh vien ra bang
       
                        load_dgv1(Data);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void load_dgv1(DataTable Data2)
        {
            //Ham cap nhat lại data cho bảng

            foreach (DataRow item in Data2.Rows)
            {
               dataGridView1.Rows.Add(item.ItemArray);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Lay ma sach can tra
            //Kiem tra no co trong sach muon hay khong 
            //xóa dữ liệu trong csdl
            //Hiển thị lại dữ liệu
            DBConnect db = new DBConnect();
            DataTable Data2;
            DataTable Data;
            string masach = textBox7.Text; // lay ma sach can tra
            string mssv = textBox1.Text;   //Lay mssv

            try
            {
                if (string.IsNullOrWhiteSpace(masach))
                {
                    MessageBox.Show("vui lòng nhập mã số sach tra");
                }
                else
                {
                    //Kiem tra no co trong sach muon hay khong 
                    string query = "SELECT * from BOOK_BORROW where UserID = " + mssv + " AND BookID= " + masach;
                    Data = db.GetDataTable(query);
                    if (Data != null)//Neu quyen sach dang duoc muon
                    {
                        // Xoa quyen sach ra khoi muon sach
                        string delete = "DELETE FROM BOOK_BORROW where UserID = " + mssv + " AND BookID= " + masach;
                        Data2 = db.GetDataTable(delete);
                        //Hiển thị lại dữ liệu
                        load_dgv1(Data2);
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
    }
}
