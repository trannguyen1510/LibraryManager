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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            //this.label1.BackColor = Color.FromArgb(17, 93, 130);
            //this.checkedListBox1.BackColor = Color.FromArgb(229, 236, 244);
            //this.groupBox1.BackColor = Color.FromArgb(229, 236, 244);
            //this.groupBox2.BackColor = Color.FromArgb(229, 236, 244);
            load_database();
        }

        private void load_database()
        {
            db = new DBConnect();
            DataTable task;
            string query = "SELECT * FROM BOOK";
            task = db.GetDataTable(query);
            load_DataTable(task);
        }

        private void load_DataTable(DataTable dataTable)
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
                materialListView1.Items.Add(listViewItem);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnReader_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            reader.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            QL_MUON_TRA muonTra = new QL_MUON_TRA();
            muonTra.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //this.checkedListBox1.ClearSelected();
            //this.txtbSearch.Text = "";

            //this.txtbCode.Text = "";
            //this.txtbName.Text = "";
            //this.txtbCategory.Text = "";
            //this.txtbAuthor.Text = "";
            //this.txtbAmount.Text = "";

            //this.listView1.Items.Clear();
        }

        private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            //e.Cancel = true;
            //e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
        }

        private void DataView_Closed()
        {
            this.materialListView1.Items.Clear();
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable task = db.Search_Book(this.mtbSearch.Text);
                if (task != null)
                {
                    DataView_Closed();
                    load_DataTable(task);
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

        private void tabPageExit_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void tabPageExit_Enter(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
