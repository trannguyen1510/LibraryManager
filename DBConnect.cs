using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace LibraryManager
{
    class DBConnect
    {
        private SQLiteConnection connection;
        string connectionString;
        private string database;
        private SQLiteDataReader reader;
        private SQLiteCommand cmd;
        private string curentPath;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            connectionString = "Data Source=D:\\CÔNG NGHỆ PHẦN MỀM\\LibraryManager-main\\lbDatabase.db; Version = 3;";

            connection = new SQLiteConnection(connectionString);
        }

        //open connection to database
        //kết nối với db để thực hiện truy vấn
        //  OpenConnection(connection);
        private void OpenConnection(SQLiteConnection connection)
        {
            if (File.Exists("D:\\CÔNG NGHỆ PHẦN MỀM\\LibraryManager-main\\lbDatabase.db"))
                connection.Open();
            else
            {
                MessageBox.Show("No Database Found");
            }
        }

        //Close connection

        private void CloseConnection(SQLiteConnection connection)
        {
            connection.Close();
        }

        // Read data
        // Nhận câu truy vấn sql và trả về kết quả dưới dạng datatable . Tự đóng csdl lại

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection(this.connection);
                if (connection.State == ConnectionState.Open)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                    CloseConnection(connection);
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        //Insert statement
        public void Insert()
        {

        }

        //Update statement
        public void Update()
        {

        }

        //Delete statement
        public void Delete()
        {

        }

        //Select statement
        public List<string>[] Select()
        {
            return null;
        }

        //Count statement
        public int Count()
        {
            return 0;
        }

        //Backup
        public void Backup()
        {

        }

        //Restore
        public void Restore()
        {

        }

        public DataTable Search_Book(string code)
        {
            string query = $"SELECT * FROM BOOK B WHERE B.ID = {code}";
            DataTable task = new DataTable();
            task = this.GetDataTable(query);

            return task;
        }
    }
}
