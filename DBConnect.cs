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
    public class DBConnect
    {
        private SQLiteConnection connection; 
        string connectionString;
        private string path;
        private SQLiteDataReader reader;
        private SQLiteCommand cmd;// d

        public SQLiteConnection Connection { get => connection; set => connection = value; }
        public object Messagebox { get; private set; }

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            var enviroment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            projectDirectory = projectDirectory.Replace(@"\", @"\\");
            path = $"{projectDirectory}\\lbDatabase.db";
            connectionString = $"Data Source={projectDirectory}\\lbDatabase.db; Version = 3;";

            Connection = new SQLiteConnection(connectionString);
        }

        //open connection to database
        //kết nối với db để thực hiện truy vấn
        //  OpenConnection(connection);
        public void OpenConnection(SQLiteConnection connection)
        {
            if (File.Exists(path))
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
                OpenConnection(this.Connection);
                if (Connection.State == ConnectionState.Open)
                {
                    cmd = Connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        reader.Close();
                        CloseConnection(Connection);
                    }
                    else
                    {
                        CloseConnection(Connection);
                        return null;
                    }
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
        public bool Insert(string query)
        {
            try
            {
                OpenConnection(this.Connection);
                if (Connection.State == ConnectionState.Open)
                {
                    cmd = Connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();  //Thuc hien chen vao csdl
                    Connection.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Update statement
        public bool Update(string query)
        {
            bool result;
            try
            {
                OpenConnection(this.Connection);
                if (Connection.State == ConnectionState.Open)
                {
                    cmd = Connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();  //Thuc hien update vao csdl
                    Connection.Close();
                    result= true;
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    result = false;
                }
            }
            catch (Exception e)
            {
                result = false;
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        //Delete statement
        public bool Delete(string query)
        {
            bool result;
            try
            {
                OpenConnection(this.Connection);
                if (Connection.State == ConnectionState.Open)
                {
                    cmd = Connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();  //Thuc hien update vao csdl
                    Connection.Close();
                    result = true;
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    result = false;
                }
            }
            catch (Exception e)
            {
                result = false;
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
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
            string query = $"SELECT B.ID, Title, Author, Name, Status FROM BOOK B JOIN CATEGORY C WHERE CategoryID = C.ID AND B.ID = {code}";
            DataTable task = GetDataTable(query);
            return task;
        }

        public DataTable Search_Reader(string code)
        {
            string query = $"SELECT * FROM READER WHERE ID = {code}";
            DataTable task = GetDataTable(query);
            return task;
        }

        public bool CheckID(string id, string table)
        {
            string query = $"SELECT id FROM {table} WHERE id = {id}";
            DataTable task = GetDataTable(query);
            if (task == null)
                return false;
            return true;
        }

        public string GetReaderID(string id)
        {
            string query = $"SELECT UserID FROM BOOK_BORROW WHERE BookID = {id}";
            DataTable task = GetDataTable(query);
            if (task == null)
                return "";
            return task.Rows[0]["UserID"].ToString();
        }

    }
}
