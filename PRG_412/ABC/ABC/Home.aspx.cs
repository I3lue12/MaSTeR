using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
public partial class Home : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {    
        if (!IsPostBack)
        {    
        }
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        int conAge;
        conAge = checkIfNotNumber(tbAge.Text);
        //conAge = Convert.ToInt16( tbAge.Text);
        //make a function for text and checking to make sure its digit.
        if (tbName.Text != "" && tbAge.Text != "")
        {
            UserInfo ui = new UserInfo();
            Session["user"] = ui;
            ui = (UserInfo)Session["user"];
            ui.Username = tbName.Text;
            if (conAge > 0)
            {
                ui.Age = 0;
            }
            else
            {
                ui.Age = Convert.ToInt16(tbAge.Text);
            }
            //ui.Age = Convert.ToInt16(tbAge.Text);
            Session["user"] = ui;
        }
        if (btnGo.Text == "Logout")//nobody currently loged in.
        {
            Session["user"] = null;
        }
       
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {  
        if (Session["user"] == null)
        {//nobody logged in
            lblMsg.Text = "Please Login";
            tbName.Visible = true;
            tbAge.Visible = true;
            lblUser.Visible = true;
            lblAge.Visible = true;
            btnDecrement.Visible = false;
            btnIncrement.Visible = false;
            btnGo.Text = "Login";

            lbMessage.Visible = false;//listbox
        }
        else
        {//someone already logged in
            UserInfo ui = (UserInfo)Session["user"];
            lblMsg.Text = "Hello, " + ui.Username + " Your age: " + ui.Age;

            tbName.Visible = false;
            tbAge.Visible = false;
            lblAge.Visible = false;
            lblUser.Visible = false;
            btnIncrement.Visible = true;
            btnDecrement.Visible = true;
            btnGo.Text = "Logout";

            lbMessage.Visible = false;//listbox
        }
    }

    protected void btnIncrement_Click(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            UserInfo ui = (UserInfo)Session["user"];      
            ui.Age = ui.Age + 1;
            Session["user"] = ui;
        }    
    }

    protected void btnDecrement_Click(object sender, EventArgs e)
    {
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
    //functions
    public int checkIfNotNumber(string tbAge)
    {
        int isNumber = Regex.Matches(tbAge, @"[a-zA-Z]").Count;

        return isNumber;
    }

}