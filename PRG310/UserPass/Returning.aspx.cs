using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace UserPass
{
    public partial class Returning : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = (MySqlConnection)Session["connection"];

            if (connection.State == System.Data.ConnectionState.Open)
            {
                Response.Write("connection is still alive");
            }
        }
    }
}