using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace DataBaseIncorp
{
    public partial class AgnosticDatabaseManager 
    {        

        public AgnosticDatabaseManager()
        {
            InitializeDatabase();
            currentErrorMessage = "none";
        }

        protected void InitializeDatabase()
        {
            SqlConnection = new MySqlConnection();
            SqlConnection.ConnectionString = "Persist Security Info = false; database = Class; server = localhost; Connect Timeout = 30; user id = root; SslMode=none";
            try
            {
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                currentErrorMessage = "Connection not open: " + ex.Message;
                return;
            }
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                currentErrorMessage = "Open";
            }
            else
            {
                currentErrorMessage = "closed connection";
                return;
            }
        }

        public List<StudentInfo> ExtractData()
        {
            List<StudentInfo> list = new List<StudentInfo>();
            string query_string = "Select * from Student";
            MySqlCommand cmd = new MySqlCommand(query_string, SqlConnection);
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                bool CanIReadData = rdr.Read();
                if (CanIReadData == true)
                {
                    while (CanIReadData == true)
                    {
                        int student_id = (int)rdr["student_id"];
                        string first_name = (string)rdr["first_name"];
                        string last_name = (string)rdr["last_name"];

                        StudentInfo s = new StudentInfo(student_id, first_name, last_name);
                        list.Add(s);
                        CanIReadData = rdr.Read(); //can I still read the data on the next line. 
                    }
                }
                return list;
            }
        }

        public string LastError()
        {
            string prevError = "none";

            return prevError;
        }

    }

}
     