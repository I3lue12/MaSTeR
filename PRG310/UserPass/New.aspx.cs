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
             //put code for database here.
        }
    }
}