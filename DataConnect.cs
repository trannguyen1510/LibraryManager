using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;
//-------------------Singleton-------------------------
//------------------Class xử lý lấy dữ liệu từ database

namespace LibraryManager
{
    public class DataConnect
    {
        private string ConnectionStr = "Data Source=D:\\Programs\\Git Repo\\LibraryManager\\lbDatabase.db; Version = 3;";

        private SQLiteConnection connect = new SQLiteConnection();

        private static DataConnect instance;

        private DataConnect() { }

        public static DataConnect Instance
        {
            get
            {
                if (instance == null)  instance = new DataConnect();
                return instance;

            }
            private set
            {
                DataConnect.instance = value;
            }
        }

        public DataTable ExcuteQuery(string query)  // hàm truy vấn tìm kiếm 
        {
            DataTable data = new DataTable();

            using (connect = new SQLiteConnection(ConnectionStr))
            {
                connect.Open();
                SQLiteCommand command = new SQLiteCommand(query, connect);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                connect.Close();

            }
            return data;

        }   

        public int ExcuteNonQuery(string query) //  hàm truy vấn Update,Insert,Delete 
        {
            int data = 0;

            using (connect = new SQLiteConnection(ConnectionStr))
            {
                connect.Open();
                SQLiteCommand command = new SQLiteCommand(query, connect);

                data = command.ExecuteNonQuery();
                connect.Close();
                
            }
            return data;

        }

        public object ExcuteScalar(string query)
        {
            object data = 0;

            using (connect = new SQLiteConnection(ConnectionStr))
            {
                connect.Open();
                SQLiteCommand command = new SQLiteCommand(query, connect);

                data = command.ExecuteScalar();
                connect.Close();

            }
            return data;

        }
    }
 }
    

