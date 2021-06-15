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
    public partial class Reader : Form
    {
        DBConnect db;
        public Reader()
        {
            InitializeComponent();
            load_database();
        }
        private void load_database()
        {
            db = new DBConnect();
            DataTable task;
            string query = "SELECT * FROM READER";
            task = db.GetDataTable(query);

            foreach (DataRow r in task.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(r["ID"].ToString());
                listViewItem.SubItems.Add(r["FullName"].ToString());
                listViewItem.SubItems.Add(r["DateOfBirth"].ToString());
                listViewItem.SubItems.Add(r["Address"].ToString());
                listViewItem.SubItems.Add(r["Email"].ToString());
                listViewItem.SubItems.Add(r["DateCreated"].ToString());
                listViewItem.SubItems.Add(r["Code"].ToString());

                this.listView1.Items.Add(listViewItem);
            }
        }
    }
}
