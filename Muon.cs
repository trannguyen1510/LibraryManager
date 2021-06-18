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

        private void button1_Click(object sender, EventArgs e)//muon tra
        {
            this.Hide();
            QL_MUON_TRA  mt = new QL_MUON_TRA();
            mt.ShowDialog();
            this.Show();
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

        private void cho_muon_Click(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();          
            string masach = textmasach.Text;//Ma sach
            string id=  textBox3.Text; //Ma doc gia
            string tensach = texttensach.Text;// Teen sach
            string HoTen = textBox2.Text;  //Ho ten
            string Email = textBox5.Text;  //email
            string NgayMuon= dateTimePicker2.Text; //Ngay muon 
            string NgayTra = dateTimePicker1.Text;  //Ngay Tra     
            try {
                //Kiểm tra xem quyển sách muốn mượn đã từng mượn chưa 
                string sql = "SELECT * FROM BOOK_BORROW where UserID = " + id + " AND BooKID=" + "'" + masach +"'";
                 DataTable kq = db.GetDataTable(sql); // =null nêus quyển sách chưa được mượn
              
                if (kq != null )
                {
                    MessageBox.Show("Bạn mượn trùng sách!!!");
                    return;
                }
                else
                {
                    //Lấy số sách mà sinh viên đó mượn
                    string sql1 = "SELECT BooKID from BOOK_BORROW where  UserID = " + id + " AND Status=1";
                   DataTable kq1 = db.GetDataTable(sql1);
                    int num_book = kq1.Rows.Count;

                    if (num_book <= 3)//Nếu mượn và sl mượn <=3 thì 
                    {
                        //Lưu vào csdl
                        string sql2 = "INSERT INTO BOOK_BORROW VALUES(" + id + "," + "'" + masach  +"'"+ "," + "'" + NgayMuon + "'" + "," + "'" + NgayTra + "'" + ",1)" ;

                        bool kq2 = db.Insert(sql2);
                        //Xuất ra bảng: lay het cac ma sach con dang muon 
                        string query = "SELECT* FROM BOOK_BORROW WHERE Status = '1' and UserID=" + id;
                        DataTable Data = db.GetDataTable(query);

                        string[] row = new string[] { Data.Rows[0][0].ToString(), Data.Rows[0][1].ToString(), Data.Rows[0][2].ToString(), Data.Rows[0][3].ToString() };

                        dataGridView1.Rows.Add(row);

                        //dataGridView1.Rows[2].Cells[1].Value = Data.Rows[1][1].ToString();
                        //dataGridView1.Rows[2].Cells[2].Value = Data.Rows[1][2].ToString();
                        //dataGridView1.Rows[2].Cells[3].Value = Data.Rows[1][3].ToString();
                        //dataGridView1.Rows[2].Cells[4].Value = Data.Rows[1][4].ToString();

                        //dataGridView1.Rows[3].Cells[1].Value = Data.Rows[2][1].ToString();
                        //dataGridView1.Rows[3].Cells[2].Value = Data.Rows[2][2].ToString();
                        //dataGridView1.Rows[3].Cells[3].Value = Data.Rows[2][3].ToString();
                        //dataGridView1.Rows[3].Cells[4].Value = Data.Rows[2][4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Quá số lượng cho phép");
                        return;
                    }
                }
            }
            catch (Exception err)
            {
               throw new Exception(err.Message);
            }
          
        }
    }

}
