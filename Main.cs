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
    public partial class Main : Form
    {
        DBConnect db;
        public Main()
        {
            InitializeComponent();
            this.label1.BackColor = Color.FromArgb(17, 93, 130);
            this.checkedListBox1.BackColor = Color.FromArgb(229, 236, 244);
            this.groupBox1.BackColor = Color.FromArgb(229, 236, 244);
            this.groupBox2.BackColor = Color.FromArgb(229, 236, 244);

            db = new DBConnect();
            DataTable task;
            string query = "SELECT * FROM BOOK";
            task = db.GetDataTable(query);

            foreach (DataRow r in task.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Title"].ToString());
                listViewItem.SubItems.Add(r["Author"].ToString());
                listViewItem.SubItems.Add(r["CategoryID"].ToString());
                listViewItem.SubItems.Add(r["Amount"].ToString());

                this.listView1.Items.Add(listViewItem);
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            DataTable task;
            string query = "SELECT * FROM BOOK";
            task = db.GetDataTable(query);

            foreach (DataRow r in task.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Title"].ToString());
                listViewItem.SubItems.Add(r["Author"].ToString());
                listViewItem.SubItems.Add(r["CategoryID"].ToString());
                listViewItem.SubItems.Add(r["Amount"].ToString());

                this.listView1.Items.Add(listViewItem);
            }
        }
        private void btnReader_Click(object sender, EventArgs e)
        {
            QL_MUON_TRA muonTra = new QL_MUON_TRA();
            muonTra.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.ClearSelected();
            this.txtbSearch.Text = "";

            this.txtbCode.Text = "";
            this.txtbName.Text = "";
            this.txtbCategory.Text = "";
            this.txtbAuthor.Text = "";
            this.txtbAmount.Text = "";

            //this.listView1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            //e.Cancel = true;
            //e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView_Closed();
            DataTable task = db.Search_Book(this.txtbSearch.Text);
            foreach (DataRow r in task.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(r["ID"].ToString());
                listViewItem.SubItems.Add(r["Title"].ToString());
                listViewItem.SubItems.Add(r["Author"].ToString());
                listViewItem.SubItems.Add(r["CategoryID"].ToString());
                listViewItem.SubItems.Add(r["Amount"].ToString());
                listView1.Items.Add(listViewItem);
            }
        }

        private void DataView_Closed()
        {
            this.listView1.Items.Clear();
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
