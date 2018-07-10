using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace UserPass
{
    public partial class Default : System.Web.UI.Page
    {
       
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {

            errorCheck.Visible = false;


            string dbName = "CoolWeb";
            string connection_param = "Data source=localhost;Database=" + dbName + ";User Id=root;Password=\"\";SSL Mode=None";
            connection = new MySqlConnection(connection_param);
            try //place holder for code that does work.
            {
              connection.Open();
              Session["connection"] = connection;
            }
              catch(Exception ex)
            {
                errorCheck.Visible = true;
                errorCheck.Text = "Error - Message: " + ex.Message;
            }            
        }

        protected void SignInSignUp(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.ID == "btnSignIn")
            {
                Response.Redirect("Returning.aspx");
            }
            else if( btn.ID == "btnSignUp")
            {
                Response.Redirect("New.aspx");
            }
            else
            {
                //please make button choice
            }
        }
    }
}