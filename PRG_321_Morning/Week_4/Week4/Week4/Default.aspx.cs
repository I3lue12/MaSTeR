using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{   public string select;
    protected void Page_PreInit(object sender, EventArgs e)       /*1*/{ }
    protected void Page_Init(object sender, EventArgs e)          /*2*/{ /*Response.Write("<h1 style=\"color: blue;\">My dynamic Web</h1>"); write c# code to write html*/}
    protected void Page_InitComplete(object sender, EventArgs e)  /*3*/{ }
    protected void Page_PreLoad(object sender, EventArgs e)       /*4*/{ }
    protected void Page_Load(object sender, EventArgs e)          /*5*/{/*Button1.BackColor = System.Drawing.Color.Blue;*/}

    protected void Page_Control_events(object sender, EventArgs e)/*6*/{ }

    


    protected void OnSelectedChange(object sender, EventArgs e)//selected event arg.
    {
        //select = lstBoxItemsAdded.SelectedItem.ToString();    
        lbl_ListBoxSelection.Text = lstBoxItemsAdded.SelectedItem.Text;
        //lbl_ListBoxSelection.Text = select;
        
    }
    
    protected void Button_Click(object sender, EventArgs e)
    {
        string content = txtBoxItemEnter.Text;
        if (string.Empty == content)
        {
            return;
        }        
        lstBoxItemsAdded.Items.Add(content);
        //select = content;
        txtBoxItemEnter.Text = "";        
        
    }
    

   
    protected void Page_LoadComplete(object sender, EventArgs e)      /*7*/ { }
    protected void Page_PreRender(object sender, EventArgs e)         /*8*/ { }
    protected void Page_PreRenderComplete(object sender, EventArgs e) /*9*/ { }
    protected void Page_SaveStateComplete(object sender, EventArgs e)/*10*/ { }
    protected void Page_Render(object sender, EventArgs e)           /*11*/ { }
    protected void Page_Unload(object sender, EventArgs e)           /*12*/ { }


    protected void SelectedText(object sender, EventArgs e)                 { }

   
}