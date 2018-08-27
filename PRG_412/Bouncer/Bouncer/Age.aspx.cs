using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Age : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   //Phace A
        if (Session["user"] == null)//bouncer check.
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {   //Phace B       
            Session["user"] = null;
            Response.Redirect("Login.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {       //Phace B
        if (Session["user"] != null)
        {
            UserInfo ui = (UserInfo)Session["user"];
            ui.Age = ui.Age + 1;
            Session["user"] = ui;
        }
    }

    protected void btnSub_Click(object sender, EventArgs e)
    {        //Phace B
        if (Session["user"] != null)
        {
            UserInfo ui = (UserInfo)Session["user"];//"copy" of session  
            ui.Age = ui.Age - 1;
            if (ui.Age < 0)
            {
                ui.Age = 0;
            }
            Session["user"] = ui;//store it back into session with new information.
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {  //Phase C
       if(Session["user"] != null)
        {
           UserInfo ui = (UserInfo)Session["user"];
            lblLoginUser.Text = "Hello, " + ui.Username + " , you are now " + ui.Age + " years old."; 
        }   
    }
}