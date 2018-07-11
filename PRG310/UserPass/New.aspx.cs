using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace UserPass
{
    public partial class New : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving connection
            connection = (MySqlConnection)(Session["connection"]);

        }

        protected void addUser(object sender, EventArgs e)
        {
            string u_login = login.Value.ToString();
            string u_userName = login.Value.ToString();
            string u_password = password.Value.ToString();

            string query2 = "INSERT INTO ENTRIES(LOGIN,USERNAME,PASSWORD) VALUES(" + u_login + "," + u_userName + "," + u_password + ");";
            MySqlCommand cmd = new MySqlCommand(query2, connection);
            try
            {
                cmd.ExecuteNonQuery();
                lblConnection.Text = "Insertion performed correctly";
            }
            catch(Exception ex)
            {
                lblConnection.Text = ex.Message; 
            }

        }
       
    }
}