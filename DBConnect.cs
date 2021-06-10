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
            var enviroment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            projectDirectory = projectDirectory.Replace(@"\", @"\\");
            connectionString = $"Data Source={projectDirectory}\\lbDatabase.db; Version = 3;";

            connection = new SQLiteConnection(connectionString);
        }

        //open connection to database
        private void OpenConnection(SQLiteConnection connection)
        {
            if (File.Exists("D:\\Programs\\Git Repo\\LibraryManager\\lbDatabase.db"))
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
        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection(connection);
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
    }
}
