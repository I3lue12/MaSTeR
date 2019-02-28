using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {  //Phase A

    }


    protected void btn_Login(object sender, EventArgs e)
    {   //Phase B
        int conAge;
        conAge = checkIfNotNumber(txbAge.Text);
        
        if (txbUser.Text != "" && txbAge.Text != "")
        {
            UserInfo ui = new UserInfo();
            Session["user"] = ui;
            ui = (UserInfo)Session["user"];
            ui.Username = txbUser.Text;

            if (conAge > 0)
            {
                ui.Age = 0;
            }
            else
            {
                ui.Age = Convert.ToInt16(txbAge.Text);
            }
            
            Session["user"] = ui;
            Response.Redirect("Age.aspx");
        }
        
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {  //Phase C
      
    }
    public int checkIfNotNumber(string tbAge)
    {
        int isNumber = Regex.Matches(tbAge, @"[a-zA-Z]").Count;

        return isNumber;
    }

}