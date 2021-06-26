using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace LibraryManager
{
    public partial class Main : MaterialForm
    {
        DBConnect db;
        private readonly MaterialSkinManager materialSkinManager;
        public Main()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue300, Primary.Blue500, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);
            load_database();
        }

        // -----------------------------------------------------------------------------------------------
        // Home tab
        private void load_database()
        {
            db = new DBConnect();
            DataTable task;
            string query = "SELECT * FROM BOOK";
            task = db.GetDataTable(query);
            load_DataTableHome(task);
        }

        private void load_DataTableHome(DataTable dataTable)
        {
            int i = 1;
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Title"].ToString());
                listViewItem.SubItems.Add(r["Author"].ToString());
                listViewItem.SubItems.Add(r["CategoryID"].ToString());
                i++;
                materialHomeListView.Items.Add(listViewItem);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            //{
            //    checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
            //    checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            //    checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            //}
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            QL_MUON_TRA muonTra = new QL_MUON_TRA();
            muonTra.Show();
        }

        private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            //e.Cancel = true;
            //e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
        }

        private void DataView_Closed()
        {
            this.materialHomeListView.Items.Clear();
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable task = db.Search_Book(this.mtbHomeSearch.Text);
                if (task != null)
                {
                    DataView_Closed();
                    load_DataTableHome(task);
                }
                else
                {
                    MessageBox.Show("Không có sách cần tìm");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        // -----------------------------------------------------------------------------------------------
        //
        //
        // Borrow tab

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            DataTable task;
            string maso = textmasach.Text;
            if (string.IsNullOrWhiteSpace(maso))
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

        private void materialButton1_Click(object sender, EventArgs e)
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

        private void load_DataTable_BR(DataTable dataTable)
        {
            int i = 1;
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(r["UserID"].ToString());
                listViewItem.SubItems.Add(r["BOOkID"].ToString());
                listViewItem.SubItems.Add(r["BorrowDay"].ToString());
                listViewItem.SubItems.Add(r["ReturnDay"].ToString());
                listViewItem.SubItems.Add(r["Status"].ToString());
                i++;
                materialHomeListView.Items.Add(listViewItem);
            }
        }

      
        private void cho_muon_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            string masach = textmasach.Text;//Ma sach
            string id = textBox3.Text; //Ma doc gia
            string tensach = texttensach.Text;// Teen sach
            string HoTen = textBox2.Text;  //Ho ten
            string Email = textBox5.Text;  //email
            string NgayMuon = dateTimePicker2.Text; //Ngay muon 
            string NgayTra = dateTimePicker1.Text;  //Ngay Tra     
            try
            {
                //Kiểm tra xem quyển sách muốn mượn đã từng mượn chưa 
                string sql = "SELECT * FROM BOOK_BORROW where UserID = " + id + " AND BooKID=" + "'" + masach + "'";
                DataTable kq = db.GetDataTable(sql); // =null nêus quyển sách chưa được mượn

                if (kq != null)
                {
                    MessageBox.Show("Bạn mượn trùng sách!!!");
                    return;
                }
                else
                {
                    //Lấy số sách mà sinh viên đó mượn
                    string sql1 = "SELECT BooKID from BOOK_BORROW where  UserID = " + id + " AND Status=1";
                    DataTable kq1 = db.GetDataTable(sql1);     //   ------------------------> Lỗi status không có ở đây, vì ở bảng BOOK_BORROW không có thuộc tính Status
                    int num_book = kq1.Rows.Count;

                    if (num_book <= 3)//Nếu mượn và sl mượn <=3 thì 
                    {
                        //Lưu vào csdl
                        string sql2 = "INSERT INTO BOOK_BORROW VALUES(" + id + "," + "'" + masach + "'" + "," + "'" + NgayMuon + "'" + "," + "'" + NgayTra + "'" + ",1)";

                        bool kq2 = db.Insert(sql2);
                        //Xuất ra bảng: lay het cac ma sach con dang muon 
                        string query = "SELECT* FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE Status = '1' and UserID= " + id;
                        DataTable Data2 = db.GetDataTable(query);

                        //string[] row = new string[] { Data.Rows[0][0].ToString(), Data.Rows[0][1].ToString(), Data.Rows[0][2].ToString(), Data.Rows[0][3].ToString() };

                        // dataGridView1.Rows.Add(row);
                        load_DataTable_BR(Data2);

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



        // Put code here





        // -----------------------------------------------------------------------------------------------
        //
        //
        // Reader tab




        // Put code here





        // -----------------------------------------------------------------------------------------------
        //
        //
        // Category tab




        // Put code here





        // -----------------------------------------------------------------------------------------------
        //
        //
        // Exit tab
        private void tabPageExit_Enter(object sender, EventArgs e)
        {
            Close();
        }

        private void ngaytra_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_a_Click(object sender, EventArgs e)
        {

        }

        private void button4_aa_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void loaisach_Click(object sender, EventArgs e)
        {

        }

      
    }
}
