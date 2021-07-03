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
        private int check = 0;
        public Main()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue300, Primary.Blue500, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);
            load_database_Home();


        }

        // -----------------------------------------------------------------------------------------------
        // Home tab
        private void load_database_Home()
        {
            db = new DBConnect();
            DataTable task;
            string query = "SELECT B.ID, Title, Author, Name, Status FROM BOOK B JOIN CATEGORY C WHERE CategoryID = C.ID";
            task = db.GetDataTable(query);
            materialHomeListView.Items.Clear();   // Clear old data
            load_DataTable_Home(task);
        }

        private void load_DataTable_Home(DataTable dataTable)
        {
            int i = 1;
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Title"].ToString());
                listViewItem.SubItems.Add(r["Author"].ToString());
                listViewItem.SubItems.Add(r["Name"].ToString());
                if (r["Status"].ToString() == "0")
                {
                    listViewItem.SubItems.Add("Còn");
                }
                else
                {
                    listViewItem.SubItems.Add("Đã mượn");
                }
                i++;
                materialHomeListView.Items.Add(listViewItem);
            }
        }

        private void tabpageHome_Enter(object sender, EventArgs e)
        {

        }

        private void materialButtonHomeReload_Click(object sender, EventArgs e)
        {
            load_database_Home(); // Refresh data  table
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
                DataTable task = db.Search_Book(mtbHomeSearch.Text);
                if (task != null)
                {
                    DataView_Closed();
                    load_DataTable_Home(task);
                }
                else
                {
                    MessageBox.Show("Không có sách cần tìm");
                }
                check = 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void materialHomeListView_DoubleClick(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPageDetail;
            materialTextBoxDetailID.Text = materialHomeListView.SelectedItems[0].SubItems[1].Text;
            materialTextBoxDetailTitle.Text = materialHomeListView.SelectedItems[0].SubItems[2].Text;
            materialTextBoxDetailAuthor.Text = materialHomeListView.SelectedItems[0].SubItems[3].Text;
            materialTextBoxDetailCategory.Text = materialHomeListView.SelectedItems[0].SubItems[4].Text;
            if (materialHomeListView.SelectedItems[0].SubItems[5].Text == "Còn")
            {
                materialTextBoxDetailStatus.Text = "Chưa được mượn";
            }
            else
            {
                materialTextBoxDetailStatus.Text = "Đã mượn";
            }
        }

        // -----------------------------------------------------------------------------------------------
        //
        //
        // Detail tab
        private void materialButtonDetailBorrow_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPageBorrow;
            textmasach.Text = materialTextBoxDetailID.Text;
            button1_Click(sender, e);
        }

        private void materialButtonDetailReturn_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPageHome;
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
                materialListView2.Items.Add(listViewItem);
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
                    string sql1 = "SELECT BooKID from BOOK_BORROW where  UserID = " + id ;
                    DataTable kq1 = db.GetDataTable(sql1);     
                    int num_book = kq1.Rows.Count;

                    if (num_book <= 3)//Nếu mượn và sl mượn <=3 thì 
                    {
                        //Lưu vào csdl
                        string sql2 = "INSERT INTO BOOK_BORROW VALUES(" + id + "," + "'" + masach + "'" + "," + "'" + NgayMuon + "'" + "," + "'" + NgayTra + "'" + ")";
                        bool kq2 = db.Insert(sql2);
                        //Xuất ra bảng: lay het cac ma sach con dang muon 
                        string query = "SELECT UserID, BookID,BorrowDay,ReturnDay, Status FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE UserID= " + id; //Status = '1' and
                         DataTable Data2 = db.GetDataTable(query);

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



        // end borrow

        //-------------------------------------------------------------------------------------------------------------------
        //
        //
        //
        //  return 
        private void load_DataTable_Search(DataTable dataTable)
        {
            int i = 1;
           
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(r["UserID"].ToString());
                listViewItem.SubItems.Add(r["BookID"].ToString());
                listViewItem.SubItems.Add(r["BorrowDay"].ToString());
                listViewItem.SubItems.Add(r["ReturnDay"].ToString());
                listViewItem.SubItems.Add(r["Status"].ToString());
                i++;
                materialListView3.Items.Add(listViewItem);
            }

        }
        private void button1_a_Click(object sender, EventArgs e)
        {
            //tim
            //Nhap ma sinh vien--> Hien thi ra thong tin sinh vien vaf cac cuon sach da muon
            //Ho va ten 
            //Dia chi
            //Email
            //MSSV
            //Ngay sinh

            DBConnect db = new DBConnect();
            DataTable Table;
            DataTable Data;
            string id = textBox1_a.Text;// lay ma doc gia
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("vui lòng nhập mã số");
                }
                else
                {
                    string query = "SELECT * FROM READER where ID = " + id;
                    string query2 = "SELECT UserID, BookID,BorrowDay,ReturnDay, Status FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE UserID= " + id;
                    Table = db.GetDataTable(query);
                    Data = db.GetDataTable(query2);
                    if (Table != null)
                    {
                        //HIen thi thong tin sinh vien
                        textBox4_a.Text = Table.Rows[0][0].ToString();  //MSSV             
                        textBox2_a.Text = Table.Rows[0][1].ToString();  //Ho va ten
                        textBox6_a.Text = Table.Rows[0][2].ToString();  //Ngay sinh
                        textBox5_a.Text = Table.Rows[0][3].ToString();  //Dia chi
                        textBox3_a.Text = Table.Rows[0][4].ToString();  //Email
                                                                        //Hien thi thong tin muon sach sinh vien ra bang
                       
                        load_DataTable_Search(Data);
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
        private void load_DataTable_Return(DataTable dataTable)
        {
            int i = 1;
           
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(r["UserID"].ToString());
                listViewItem.SubItems.Add(r["BookID"].ToString());
                listViewItem.SubItems.Add(r["BorrowDay"].ToString());
                listViewItem.SubItems.Add(r["ReturnDay"].ToString());
                listViewItem.SubItems.Add(r["Status"].ToString());
                i++;
                materialListView3.Items.Add(listViewItem);
            }

        }
        private void button4_aa_Click(object sender, EventArgs e)
        {
            ///Nut tra
             //Lay ma sach can tra
            //Kiem tra no co trong sach muon hay khong 
            //xóa dữ liệu trong csdl
            //Hiển thị lại dữ liệu
            DBConnect db = new DBConnect();
            DataTable Data2;
            DataTable Data;
            string masach = textBox7_a.Text; // lay ma sach can tra
            string mssv = textBox1_a.Text;   //Lay mssv

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
                       // materialListView3.Items.Clear();   // Clear old data
                        load_DataTable_Return(Data2);
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

        // materialListView3.Items.Clear();   // Clear old data



        // -----------------------------------------------------------------------------------------------
        //
        //
        // Reader tab
        private void load_DataTable_Reader(DataTable dataTable)
        {
            int i = 1;
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Fullname"].ToString());
                listViewItem.SubItems.Add(r["DateOfBirth"].ToString());
                listViewItem.SubItems.Add(r["Address"].ToString());
                listViewItem.SubItems.Add(r["Email"].ToString());
                listViewItem.SubItems.Add(r["DateCreated"].ToString());
                i++;
                materialReaderListView.Items.Add(listViewItem);
            }
        }

        private void load_database_Reader()
        {
            db = new DBConnect();
            DataTable task;
            string query = "SELECT * FROM READER";
            task = db.GetDataTable(query);
            materialReaderListView.Items.Clear();   // Clear old data
            load_DataTable_Reader(task);
        }


        private void tabPageReader_Enter(object sender, EventArgs e)
        {
            load_database_Reader();   // Refresh data  table
        }


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

 

        

        private void textBox5_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void loaisach_Click(object sender, EventArgs e)
        {

        }
    }
}
