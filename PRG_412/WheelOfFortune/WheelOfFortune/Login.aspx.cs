using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {  //Phase A
        if(!IsPostBack)               //once first time user goes to page.
        {
            ddlDif.Items.Add("");//prevent auto selection leave blank
            ddlDif.Items.Add("Easy");
            ddlDif.Items.Add("Medium");
            ddlDif.Items.Add("Hard"); 
        }
    }

    protected void tbName_TextChanged(object sender, EventArgs e)
    {   //Phase B
       
    }

    protected void ddlDif_SelectedIndexChanged(object sender, EventArgs e)
    {//phace B
        
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {  //Phase C

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {   
        if (tbName.Text.Length > 0)
        { 
            if (ddlDif.SelectedIndex > 0)
            {  
                UserInfo ui = new UserInfo();
                ui.Username = tbName.Text;
                if (ddlDif.SelectedIndex == 1)
                {
                    ui.LevelDifficulty = Level.Easy;
                }
                else if (ddlDif.SelectedIndex == 2)
                {
                    ui.LevelDifficulty = Level.Medium;
                }
                else if (ddlDif.SelectedIndex == 3)
                {
                    ui.LevelDifficulty = Level.Hard;
                }
                Session["user"] = ui;
                Response.Redirect("Game.aspx");
            }  //make a selection for dificulty           
        }      //text for no name selected
    }
}