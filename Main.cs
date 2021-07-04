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
            materialHomeListView.Items.Clear();
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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void materialHomeListView_DoubleClick(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPageDetail;
            string book_id = materialHomeListView.SelectedItems[0].SubItems[1].Text;
            materialTextBoxDetailID.Text = book_id;
            materialTextBoxDetailTitle.Text = materialHomeListView.SelectedItems[0].SubItems[2].Text;
            materialTextBoxDetailAuthor.Text = materialHomeListView.SelectedItems[0].SubItems[3].Text;
            materialTextBoxDetailCategory.Text = materialHomeListView.SelectedItems[0].SubItems[4].Text;
            materialTextBoxDetailStatus.Text = materialHomeListView.SelectedItems[0].SubItems[5].Text;
            if (materialHomeListView.SelectedItems[0].SubItems[5].Text == "Còn")
            {
                materialTextBoxDetailReaderID.Text = "";
                materialTextBoxDetailReaderName.Text = "";
            }
            else
            {
                string reader_id = db.GetReaderID(book_id);
                if (reader_id != "")
                {
                    DataTable task2 = db.Search_Reader(reader_id);
                    DataRow row2 = task2.Rows[0];
                    materialTextBoxDetailReaderID.Text = row2["ID"].ToString();
                    materialTextBoxDetailReaderName.Text = row2["FullName"].ToString();
                }
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

        //CHECK QUÁ HẠN 
        public double Check_Date(string date_br, string date_rt)
        {
            DateTime muon = Convert.ToDateTime(date_br);
            DateTime tra = Convert.ToDateTime(date_rt);
            double sl; 
            sl = (tra - muon).TotalDays;
            return sl;
        }

        private void button1_Click(object sender, EventArgs e)//Borrow_search_BOOK_ID
        {
            DataTable task;
            string maso = textmasach.Text;
            if (string.IsNullOrWhiteSpace(maso))
            {
                MessageBox.Show("vui lòng nhập mã số");
            }
            else
            {
                string query = "SELECT B.ID, Title, Author, Name, Status FROM BOOK B JOIN CATEGORY C WHERE CategoryID = C.ID AND B.ID = " + maso;
                task = db.GetDataTable(query);
                if (task != null)//Kiêmr tra sách có tồn tại hay ko
                {
                    texttensach.Text = task.Rows[0]["ID"].ToString();
                    comboBox1.Text = task.Rows[0]["Name"].ToString();
                    texttacgia.Text = task.Rows[0]["Author"].ToString();
                }
                else
                {
                    MessageBox.Show("Sách không tồn tại");
                    return;
                }
            }
        }
        //BORROW_SEARCH_USER_ID
        private void materialButton1_Click(object sender, EventArgs e)
        {
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
                    if (temp != null)// Doc gia co ton tai hay khong
                    {
                        textBox2.Text = temp.Rows[0]["Fullname"].ToString();//họ tên
                        textBox5.Text = temp.Rows[0]["Email"].ToString();//Email
                        load_database_BR();
                    }
                    else//Neu doc gia khoong ton tai
                    {
                        MessageBox.Show("Độc giả không tồn tại!!");
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
        //Hiển thị ra dataGV_BORROW
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
                if (r["Status"].ToString() == "0")
                    listViewItem.SubItems.Add("Còn");
                else
                    listViewItem.SubItems.Add("Đã mượn");
                i++;
                materialListView2.Items.Add(listViewItem);
            }            
        }

        private void load_database_BR()
        {
            string id = textBox3.Text;
            if (id != "")
            {
                string query = "SELECT UserID, BookID,BorrowDay,ReturnDay, Status FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE UserID= " + id;
                DataTable task = db.GetDataTable(query);
                materialListView2.Items.Clear();   // Clear old data
                if (task != null)
                {
                    load_DataTable_BR(task);
                }
            }
            else
                MessageBox.Show("Không có độc giả cần tìm");
        }

        //Hàm mượn chính 
        private void cho_muon_Click(object sender, EventArgs e)
        {
            string masach = textmasach.Text;//Ma sach
            string id = textBox3.Text; //Ma doc gia
            string tensach = texttensach.Text;// Teen sach
            string HoTen = textBox2.Text;  //Ho ten
            string Email = textBox5.Text;  //email
            string NgayMuon = dateTimePicker2.Value.ToShortDateString(); //Ngay muon 
            string NgayTra = dateTimePicker1.Value.ToShortDateString();  //Ngay Tra     
            try//ys oong laf sao nãy tui thấy ở trên list có 2 cái nó trùng cả id sách và id user
            {
                //Kiểm tra xem quyển sách muốn mượn đã từng mượn chưa -->Tránh mượn trùng 
                //Vaf tình trạng quyển sách có ==0 (chưa mượn) hay chưa 
                string sql = "SELECT * FROM BOOK_BORROW bb join BOOK b on bb.BookID=b.ID where bb.UserID = " + id + " AND bb.BooKID=" + "'" + masach + "'" ;
                DataTable kq = db.GetDataTable(sql); // = null nêus quyển sách chưa được mượn

                if (kq != null)
                {
                    MessageBox.Show("Bạn mượn trùng sách hoặc sách đã được người khác mượn!!!");
                    return;
                }
                else
                {
                    //Lấy số sách mà sinh viên đó mượn
                    string sql1 = "SELECT BooKID from BOOK_BORROW where  UserID = " + textBox3.Text;
                    DataTable kq1 = db.GetDataTable(sql1);
                    int num_book;
                    if (kq1 != null)
                    {
                        num_book = kq1.Rows.Count;
                    }
                    else
                    {
                        num_book = 0;
                    }

                    if (num_book <= 3)//Nếu mượn và sl mượn <=3 và KHÔNG QUÁ HẠN  thì mới tính tiếp
                    {
                        //Lưu vào csdl thông tin người mượn và mã sách 
                        string sql2 = "INSERT INTO BOOK_BORROW VALUES(" + id + "," + "'" + masach + "'" + "," + "'" + NgayMuon + "'" + "," + "'" + NgayTra + "'" + ")";
                        bool kq2 = db.ExucuteDbCmd(sql2);
                        //Lưu vào csdl BOOK.Status==1 --> update đã được mượn
                        string sql3 = " UPDATE BOOK SET Status = 1 WHERE ID=" + masach;
                        bool kq3 = db.ExucuteDbCmd(sql3);

                        // Neu chen vaf cap nhat thanh cong thif xuat ra grid 
                        if (kq2 == true && kq3 == true)
                        {
                            //Xuất ra bảng: lay het cac ma sach con dang muon 
                            string query = "SELECT UserID, BookID,BorrowDay,ReturnDay, Status FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE UserID= " + id; //Status = '1' and
                            DataTable Data2 = db.GetDataTable(query);
                            materialListView2.Items.Clear();
                            load_DataTable_BR(Data2);
                            MessageBox.Show("Đặt mượn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Chèn thông tin mượn hoặc cập nhật sách không thành công");
                            return;
                        }
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

        private void materialListView2_Click(object sender, EventArgs e)
        {
            string id = materialListView2.SelectedItems[0].SubItems[2].Text;
            DataTable task = db.Search_Book(id);
            DataRow dataRow = task.Rows[0];
            textmasach.Text = id;
            texttensach.Text = dataRow["Title"].ToString();
            comboBox1.Text = dataRow["Name"].ToString();
            texttacgia.Text = dataRow["Author"].ToString();
            dateTimePicker2.Value = Convert.ToDateTime(materialListView2.SelectedItems[0].SubItems[3].Text);
            dateTimePicker1.Value = Convert.ToDateTime(materialListView2.SelectedItems[0].SubItems[4].Text);
        }

        private void materialListView2_DoubleClick(object sender, EventArgs e)
        {
            string book_id = materialListView2.SelectedItems[0].SubItems[2].Text;
            DataTable task = db.Search_Book(book_id);
            DataRow row = task.Rows[0];
            materialTabControl1.SelectedTab = tabPageDetail;
            materialTextBoxDetailID.Text = book_id;
            materialTextBoxDetailTitle.Text = row["Title"].ToString();
            materialTextBoxDetailAuthor.Text = row["Author"].ToString();
            materialTextBoxDetailCategory.Text = row["Name"].ToString();
            materialTextBoxDetailStatus.Text = row["Status"].ToString();

            string reader_id = materialListView2.SelectedItems[0].SubItems[1].Text;
            DataTable task2 = db.Search_Reader(reader_id);
            DataRow row2 = task2.Rows[0];
            materialTextBoxDetailReaderID.Text = row2["ID"].ToString();
            materialTextBoxDetailReaderName.Text = row2["FullName"].ToString();
        }

        // end borrow

        //-------------------------------------------------------------------------------------------------------------------
        //
        //
        //
        //  return tab


        private void load_DataTable_Search(DataTable dataTable)
        {
            int i = 0;
            if (dataTable == null)
            {
                return;
            }
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
            int i = 0;
            if (dataTable == null)
            {
                return;
            }
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
            bool Data2;
            DataTable Data3;
            DataTable Data;
            string masach = textBox7_a.Text; // lay ma sach can tra
            string mssv = textBox1_a.Text;   //Lay mssv
            //Lấy ngày trả
            string ngay_tra = date.Value.ToString();//

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

                    // Lay ngay muon tra cua quyen sach tinh qua han
                    string QuaHan = "SELECT BorrowDay FROM BOOK_BORROW WHERE UserID = " + mssv + " AND BookID= " + masach;
                    DataTable QH = db.GetDataTable(QuaHan);
                    double dem;
                    string date_br;
                    if (QH != null && QH.Rows.Count != 0)
                    {
                        //Ngày mượn
                        date_br = QH.Rows[0]["BorrowDay"].ToString();
                        dem = Check_Date(date_br, ngay_tra);
                    }
                    else
                    {
                        MessageBox.Show("Không co muon sach nao !!");
                        return;
                    }     
                  



                    string Xoa;
                    string sql_update;
                    bool result_ne;

                    if (Data != null)//Neu quyen sach dang duoc muon 
                    {
                       if (dem <= 7)// và dem <= 7-- > Muon trong so ngay quy dinh
                        {
                            // Xoa quyen sach ra khoi muon sach
                            Xoa = "DELETE FROM BOOK_BORROW where UserID = " + mssv + " AND BookID= " + masach;
                            Data2 = db.ExucuteDbCmd(Xoa);

                            //Cap nhat quyen sach ve tinh trang chua muon status==0 --> Update da tra roi                       
                            sql_update = " UPDATE BOOK SET Status = 0 WHERE ID=" + masach;
                            result_ne = db.ExucuteDbCmd(sql_update);

                            if (Data2 == true && result_ne == true)// Xóa thành công và cập nhật lại tình trạng sách 
                            {
                                //Hiển thị lại dữ liệu
                                materialListView3.Items.Clear();   // Clear old data
                                string data_new = "SELECT UserID, BookID,BorrowDay,ReturnDay, Status FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE UserID= " + mssv;
                                Data3 = db.GetDataTable(data_new);
                                load_DataTable_Return(Data3);
                                MessageBox.Show("Trả sách thành công");
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công hoặc sách đã được mượn rồi ");
                                return;
                            }
                        }
                        else
                        {
                            //Nếu số ngày mượn  > 7 ngày vẫn xóa nhưng  --> tính phạt 

                            //VẪN XÓA 
                            // Xoa quyen sach ra khoi muon sach
                            Xoa = "DELETE FROM BOOK_BORROW where UserID = " + mssv + " AND BookID= " + masach;
                            Data2 = db.ExucuteDbCmd(Xoa);

                            //Cap nhat quyen sach ve tinh trang chua muon status==0 --> Update da tra roi                       
                            sql_update = " UPDATE BOOK SET Status = 0 WHERE ID=" + masach;
                            result_ne = db.ExucuteDbCmd(sql_update);

                            if (Data2 == true && result_ne == true)// Xóa thành công và cập nhật lại tình trạng sách 
                            {
                                //Hiển thị lại dữ liệu
                                materialListView3.Items.Clear();   // Clear old data
                                string data_new = "SELECT UserID, BookID,BorrowDay,ReturnDay, Status FROM BOOK_BORROW bb join BOOK b on b.ID= bb.BookID WHERE UserID= " + mssv;
                                Data3 = db.GetDataTable(data_new);
                                load_DataTable_Return(Data3);
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công hoặc sách đã được mượn rồi ");
                                return;
                            }
                            ///XUẤT PHẠT
                            MessageBox.Show("Quá hạn : " + dem + "ngay. Bạn bị phạt!!!");
                            return;
                        }                       
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

        private void materialListView3_Click(object sender, EventArgs e)
        {
            string id = materialListView3.SelectedItems[0].SubItems[2].Text;
            textBox7_a.Text = id;
        }


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
            DataTable task;
            string query = "SELECT * FROM READER";
            task = db.GetDataTable(query);
            DataReaderView_Closed();   // Clear old data
            load_DataTable_Reader(task);
        }


        private void tabPageReader_Enter(object sender, EventArgs e)
        {
            load_database_Reader();   // Refresh data  table
        }

        private void DataReaderView_Closed()
        {
            materialReaderListView.Items.Clear();
        }

        private void materialButtonReaderSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable task = db.Search_Reader(materialTextBoxReaderID.Text);
                if (task != null)
                {
                    DataReaderView_Closed();
                    load_DataTable_Reader(task);

                    DataRow dataRow = task.Rows[0];
                    materialTextBoxReaderID.Text = dataRow["ID"].ToString();
                    materialTextBoxReaderName.Text = dataRow["FullName"].ToString();
                    dateTimePickerReader.Value = Convert.ToDateTime(dataRow["DateOfBirth"]);
                    materialTextBoxReaderAddress.Text = dataRow["Address"].ToString();
                    materialTextBoxReaderEmail.Text = dataRow["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("Không có độc giả cần tìm");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void Reader_ClearAll()
        {
            materialTextBoxReaderID.Text = "";
            materialTextBoxReaderName.Text = "";
            dateTimePickerReader.Value = DateTime.Now;
            materialTextBoxReaderAddress.Text = "";
            materialTextBoxReaderEmail.Text = "";
        }

        private void materialButtonReaderReload_Click(object sender, EventArgs e)
        {
            load_database_Reader();
            Reader_ClearAll();

        }

        private void materialButtonReaderAdd_Click(object sender, EventArgs e)
        {
            string id = materialTextBoxReaderID.Text;
            string name = materialTextBoxReaderName.Text;
            string datetime = dateTimePickerReader.Value.ToShortDateString();
            string address = materialTextBoxReaderAddress.Text;
            string email = materialTextBoxReaderEmail.Text;
            string datecreate = DateTime.Now.ToShortDateString();

            if (db.CheckID(id, "READER"))
            {
                MessageBox.Show("Trùng mã số");
            }
            else
            {
                string query = $"INSERT INTO READER VALUES({id}, '{name}', '{datetime}', '{address}', '{email}', '{datecreate}')";
                bool reader_insert = db.ExucuteDbCmd(query);
                if (reader_insert)
                {
                    MessageBox.Show("Thêm thành công");
                    Reload_All(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void materialReaderListView_Click(object sender, EventArgs e)
        {
            materialTextBoxReaderID.Text = materialReaderListView.SelectedItems[0].SubItems[1].Text;
            materialTextBoxReaderName.Text = materialReaderListView.SelectedItems[0].SubItems[2].Text;
            dateTimePickerReader.Value = Convert.ToDateTime(materialReaderListView.SelectedItems[0].SubItems[3].Text);
            materialTextBoxReaderAddress.Text = materialReaderListView.SelectedItems[0].SubItems[4].Text;
            materialTextBoxReaderEmail.Text = materialReaderListView.SelectedItems[0].SubItems[5].Text;
            dateTimePickerReader2.Value = Convert.ToDateTime(materialReaderListView.SelectedItems[0].SubItems[6].Text);
        }

        private void materialButtonReaderEdit_Click(object sender, EventArgs e)
        {
            if (materialReaderListView.SelectedItems.Count > 0)
            {
                string id = materialReaderListView.SelectedItems[0].SubItems[1].Text;
                string check_reader = db.CheckBorrow(id);
                if (check_reader != "")
                {
                    MessageBox.Show("Độc giả còn sách chưa trả");
                }
                else
                {
                    string reader_id = materialTextBoxReaderID.Text;
                    string name = materialTextBoxReaderName.Text;
                    string date_birth = dateTimePickerReader.Value.ToShortDateString();
                    string address = materialTextBoxReaderAddress.Text;
                    string email = materialTextBoxReaderEmail.Text;
                    //string date_create = DateTime.Now.ToShortDateString();

                    if (db.CheckID(reader_id, "READER"))
                    {
                        string query = $"UPDATE READER SET FullName = '{name}', DateOfBirth = '{date_birth}', Address = '{address}', Email = '{email}' WHERE ID = {id}";
                        bool result = db.ExucuteDbCmd(query);
                        if (result)
                        {
                            MessageBox.Show("Chỉnh sửa độc giả thành công");
                            Reload_All(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Chỉnh sửa không thành công");
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thay dổi mã số", "Phát hiện khác mã số", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string query = $"UPDATE READER SET ID = {reader_id}, FullName = '{name}', DateOfBirth = '{date_birth}', Address = '{address}', Email = '{email}' WHERE ID = {id}";
                            bool result = db.ExucuteDbCmd(query);
                            if (result)
                            {
                                MessageBox.Show("Chỉnh sửa độc giả thành công");
                                Reload_All(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Chỉnh sửa không thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chỉnh sửa thất bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn độc giả để chỉnh sửa");
            }

        }


        private void materialButtonReaderDelete_Click(object sender, EventArgs e)
        {
            if (materialReaderListView.SelectedItems.Count > 0)
            {
                string id = materialReaderListView.SelectedItems[0].SubItems[1].Text;
                string check_reader = db.CheckBorrow(id);
                if (check_reader != "")
                {
                    MessageBox.Show("Độc giả còn sách chưa trả");
                }
                else
                {
                    string query = $"DELETE FROM READER WHERE ID = {id}";
                    bool result = db.ExucuteDbCmd(query);
                    if (result)
                    {
                        MessageBox.Show("Xoá độc giả thành công");
                        Reload_All(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn độc giả để xóa");
            }

        }

        // -----------------------------------------------------------------------------------------------
        //
        //
        // Category tab

        private void load_DataTable_Category(DataTable dataTable)
        {
            foreach (DataRow r in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Name"].ToString());
                materialListViewCategory.Items.Add(listViewItem);
            }
        }

        private void DataCategoryView_Closed()
        {
            materialListViewCategory.Items.Clear();
        }

        private void load_database_Category()
        {
            DataTable task;
            string query = "SELECT * FROM CATEGORY";
            task = db.GetDataTable(query);
            DataCategoryView_Closed();   // Clear old data
            load_DataTable_Category(task);
        }

        private void materialListViewCategory_Click(object sender, EventArgs e)
        {
            materialTextBoxCategoryName.Text =  materialListViewCategory.SelectedItems[0].SubItems[1].Text;
        }

        private void tabPageCategory_Enter(object sender, EventArgs e)
        {
            load_database_Category();
        }

        private void materialButtonCategoryAdd_Click(object sender, EventArgs e)
        {
            string name = materialTextBoxCategoryName.Text;
            if (db.CheckName(name, "CATEGORY"))
            {
                MessageBox.Show("Đã tồn tại");
            }
            else
            {
                string check = "SELECT Name FROM CATEGORY";
                DataTable task = db.GetDataTable(check);
                string id;
                if (task.Rows.Count > 0)
                {
                    id = (task.Rows.Count + 1).ToString();
                }
                else
                {
                    id = (0).ToString();
                }
                string query = $"INSERT INTO CATEGORY VALUES({id}, '{name}')";
                bool category_insert = db.ExucuteDbCmd(query);
                if (category_insert)
                {
                    MessageBox.Show("Thêm thành công");
                    Reload_All(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void materialButtonCategoryEdit_Click(object sender, EventArgs e)
        {
            if (materialListViewCategory.SelectedItems.Count > 0)
            {
                string id = materialListViewCategory.SelectedItems[0].SubItems[0].Text;
                string name = materialTextBoxCategoryName.Text;
                int check_category = db.CheckCategory(id);
                if (check_category != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn thay dổi danh mục\nSẽ có {check_category} sách bị ảnh hưởng", "Phát hiện có sách thuộc danh mục", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = $"UPDATE CATEGORY SET Name = '{name}' WHERE ID = {id}";
                        bool result = db.ExucuteDbCmd(query);
                        if (result)
                        {
                            MessageBox.Show($"Chỉnh sửa danh mục thành công\n{check_category} sách đã được thay đổi");
                            Reload_All(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Chỉnh sửa không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa thất bại");
                    }
                }
                else
                {
                    string query = $"UPDATE CATEGORY SET Name = '{name}' WHERE ID = {id}";
                    bool result = db.ExucuteDbCmd(query);
                    if (result)
                    {
                        MessageBox.Show("Chỉnh sửa danh mục thành công");
                        Reload_All(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh mục để chỉnh sửa");
            }
        }

        private void materialButtonCategoryDelete_Click(object sender, EventArgs e)
        {
            if (materialListViewCategory.SelectedItems.Count > 0)
            {
                string id = materialListViewCategory.SelectedItems[0].SubItems[0].Text;
                string name = materialTextBoxCategoryName.Text;
                int check_category = db.CheckCategory(id);
                if (check_category != -1)
                {
                     MessageBox.Show($"Không thể xóa danh mục\nCó {check_category} sách thuộc danh mục này");
                }
                else
                {
                    string query = $"DELETE FROM CATEGORY WHERE ID = {id}";
                    bool result = db.ExucuteDbCmd(query);
                    if (result)
                    {
                        MessageBox.Show("Xóa danh mục thành công");
                        Reload_All(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh mục để xóa");
            }
        }

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

        private void materialButtonBorrowReload_Click(object sender, EventArgs e)
        {
            textmasach.Text = "";
            texttensach.Text = "";
            comboBox1.Text = "";
            texttacgia.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            materialListView2.Items.Clear();
        }

        private void materialButtonReturnReload_Click(object sender, EventArgs e)
        {
            textBox1_a.Text = "";
            textBox2_a.Text = "";
            textBox3_a.Text = "";
            textBox4_a.Text = "";
            textBox5_a.Text = "";
            textBox6_a.Text = "";
            textBox7_a.Text = "";
            date.Value = DateTime.Now;
            materialListView3.Items.Clear();
        }

        private void materialButtonDetailReload_Click(object sender, EventArgs e)
        {
            materialTextBoxDetailID.Text = "";
            materialTextBoxDetailTitle.Text = "";
            materialTextBoxDetailAuthor.Text = "";
            materialTextBoxDetailCategory.Text = "";
            materialTextBoxDetailStatus.Text = "";
            materialTextBoxDetailReaderID.Text = "";
            materialTextBoxDetailReaderName.Text = "";
        }

        private void materialButtonCategoryReload_Click(object sender, EventArgs e)
        {
            materialTextBoxCategoryName.Text = "";
            load_database_Category();
        }

        private void Reload_All(object sender, EventArgs e)
        {
            materialButtonHomeReload_Click(sender, e);
            materialButtonDetailReload_Click(sender, e);
            materialButtonBorrowReload_Click(sender, e);
            materialButtonReturnReload_Click(sender, e);
            materialButtonReaderReload_Click(sender, e);
            materialButtonCategoryReload_Click(sender, e);
        }
    }
}
