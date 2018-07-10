using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace webLearn
{
    public partial class page1 : System.Web.UI.Page
    {
        private MySqlConnection mConnection;
        protected void Page_Unload(object sender, EventArgs e)
        {
            mConnection.Close();
            Session["P1 unload"] = true;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mConnection = new MySqlConnection("Data source=localhost;Database=STUDENT;User Id=root;Password=\"\";SSL Mode=None");
           

            try
            {
                mConnection.Open();
                if (mConnection.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("CNX success");
                }
            }
            catch(Exception exe)
            {
                 Response.Write("Reason For none connection" + exe.Message);
            }
            //creating a seeion variable
            Session["P1 unload"] = false;
            
        }

        protected void GoToNextPage(object sender, EventArgs e)
        {
           
            string cnx_state = "closed";
            if(mConnection.State == System.Data.ConnectionState.Open)
            {
                cnx_state = "open";
            }
            //page2.aspx?   the ? sends the state when betton is pressed
            Response.Redirect("Page2.aspx?state= " + cnx_state);
        }
    }
}