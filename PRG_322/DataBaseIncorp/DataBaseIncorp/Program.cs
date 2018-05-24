using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace DataBaseIncorp
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        AgnosticDatabaseManager manager = new AgnosticDatabaseManager();
    //        List<StudentInfo> students = manager.ExtractData();
    //        //Console.WriteLine(manager.ExtractData());

    //        //for(int i = 0; i<students.Count; i++)
    //        //{
    //        //    Console.WriteLine("ID = " + students[i].ID + " -First name = " + students[i].FirstName);
    //        //}

    //        //Console.ReadKey();

    //        #region   transfered all code

    //        ////string  connection = "C:\xampp\Script\DBPRG_351.sql";
    //        //MySqlConnection SqlConnection = new MySqlConnection();
    //        ////why do we put this in
    //        //SqlConnection.ConnectionString = "Persist Security Info = false; database = Class; server = localhost; Connect Timeout = 30; user id = root; SslMode=none";
    //        //try//open can be thrown.
    //        //{
    //        //    SqlConnection.Open();
    //        //}
    //        //catch(Exception ex)
    //        //{
    //        //    Console.WriteLine("Connection not open: " + ex.Message);
    //        //    return;
    //        //}
    //        //if(SqlConnection.State == System.Data.ConnectionState.Open)
    //        //{                
    //        //    //MySqlDataReader OutData;
    //        //    Console.WriteLine("Open");
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("closed connection");
    //        //    return;
    //        //}
    //        //string query_string = "Select * from Student";
    //        //MySqlCommand cmd = new MySqlCommand(query_string, SqlConnection);
    //        //using(MySqlDataReader rdr = cmd.ExecuteReader())  //using is local using makes rdr only alive in the braces.
    //        //{
    //        //    bool CanIReadData = rdr.Read();
    //        //    if (CanIReadData == true)//this makes it so we could use a do while loop, instead of using just a while loop.
    //        //    {

    //        //        foreach (MySqlDataReader a in rdr) //try out later.
    //        //        {

    //        //        }
    //        //        while (CanIReadData == true) 
    //        //        {
    //        //            int student_id = (int)rdr["student_id"];
    //        //            string first_name = (string)rdr["first_name"];
    //        //            string last_name = (string)rdr["last_name"];
    //        //            Console.WriteLine("Student Number: " + student_id);
    //        //            Console.WriteLine("Student First Name: " + first_name);
    //        //            Console.WriteLine("Student Last Name: " + last_name);
    //        //            CanIReadData = rdr.Read(); //can I still read the data on the next line.
    //        //        }
    //        //        //while (rdr.Read()) //skips the first line/row.
    //        //        //{
    //        //        //    int student_id = (int)rdr["student_id"];
    //        //        //    string first_name = (string)rdr["first_name"];
    //        //        //    string last_name = (string)rdr["last_name"];
    //        //        //    Console.WriteLine("Student Number: " + student_id);
    //        //        //    Console.WriteLine("Student First Name: " + first_name);
    //        //        //    Console.WriteLine("Student Last Name: " + last_name);
    //        //        //}
    //        //        //do//so we can read the first line.
    //        //        //    {
    //        //        //        //int student_id = (int)rdr["student_id"];
    //        //        //        //string first_name = (string)rdr["first_name"];
    //        //        //        //string last_name = (string)rdr["last_name"];
    //        //        //        int student_id = rdr.GetInt32(0);
    //        //        //        string first_name = rdr.GetString(1);
    //        //        //        string last_name = rdr.GetString(2);                       

    //        //        //        Console.WriteLine("Student Number: " + student_id);
    //        //        //        Console.WriteLine("First Name: " + first_name);
    //        //        //        Console.WriteLine("Last Name: " + last_name);

    //        //        //    } while (rdr.Read());
    //        //    }
    //        //}
    //        ////if we did not use using we would need to close the sql reader.
    //        //Console.Read(); 
    //        #endregion
    //    }



    //}
}
