using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
namespace webLearn
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection query_string = Request.QueryString;
            string statePage1 = query_string["state"];
            Response.Write("the state of sql connection from page 1: " + statePage1 + "</br>");

            bool stateP1Unloaded = (bool)Session["P1 unload"];
            Response.Write("and page 1 is " + stateP1Unloaded+ "</br>");
        }
    }
}