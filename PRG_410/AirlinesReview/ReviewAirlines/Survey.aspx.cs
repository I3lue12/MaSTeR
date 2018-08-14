using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

namespace ReviewAirlines
{
    public partial class Survey : System.Web.UI.Page
    {
        MySqlConnection cnx;
        List<RadioButtonList> lst;
        List<string> lstSurvey;
        List<int> lstSurveyNum;
        int numberItems;
        List<ListItem> items;

        protected override void OnInit(EventArgs e)
        {
            
        }
       

        protected void ProcessSelection(object sender, EventArgs e)//this is to get the selected index for the listbox
        {
            int a = 0;
            int b = 2;
            //ListBox1.
            ListBox lb = (ListBox)sender;
            int indexSelected = 0;
            try
            {
                indexSelected = lb.SelectedIndex;
            }
            catch (Exception ex)
            {
                ;
            }
            if (indexSelected == -1)
                return;
            Session["LB"] = lb.Items[indexSelected].Text;
            return;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //CONNECTION
            string s = "Data Source=localhost;DataBase=flights;User Id=root;Password=\"\";SSL Mode=None";
            if (ListBox1.Items.Count <1)
            {
                lblSurvey.Text = ListBox1.Items.Count.ToString();   
            }

            if (Session["items"] != null)   {
                ListItemCollection c = (ListItemCollection)Session["items"];
                if (c.Count < 1)
                    lblSurvey.Text = "You don't have any item in your session variable.";
                else
                    lblSurvey.Text = "You have " + c.Count + " elements in the lb.";
            }  else {
                if( Page.IsPostBack )
                    lblSurvey.Text = "items are gone... Poof";
            }

            if (!Page.IsPostBack)             // the page is loading for the first time
            {
                cnx = new MySqlConnection(s);
                items = new List<ListItem>();
                List<int> myList = new List<int>();
                Session["list1"] = myList;

                lstSurvey = new List<string>();
                lstSurveyNum = new List<int>();

                Session["lstSurvey"] = lstSurvey;
                Session["lstSurveyNum"] = lstSurveyNum;
                try
                {
                    cnx.Open();
                }
                catch (Exception ex)
                {
                    Response.Write("Error while opening connection - Reason = " + ex.Message);
                    return;
                }
                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("connection successful");
                    string query = "Select * FROM details";
                    MySqlCommand cmd = new MySqlCommand(query, cnx);
                    int count = 0;
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            do
                            {
                                //put in list box
                                //deescribe details;

                                int a1 = (int)rdr["flight_num"];
                                string a2 = (string)rdr["airline_code"];
                                DateTime s3 = (DateTime)rdr["departure_time"];
                                DateTime s4 = (DateTime)rdr["arrival_time"];
                                string a3 = (string)rdr["departure"];
                                string a4 = (string)rdr["arrival"];
                                //arrival
                                string flightNUm = "Flight Number: " + a1 + ", ";
                                string airlineCode = "Airline: " + a2 + ", ";
                                string Departure = "Departure: " + s3 + ", ";
                                string arrival = "Arrival: " + s4 + ", ";
                                string LocationDepart = "From: " + a3 + ", ";
                                string LocationTo = "To: " + a4;

                                ListItem li = new ListItem();

                                li.Text = flightNUm + airlineCode + Departure + arrival + LocationDepart + LocationTo + "\n";
                                //// li.Text = entry;

                                items.Add(li);
                                //ListBox1.Items.Add(items[count ]);
                                count++;

                            } while (rdr.Read());
                            lblSurvey.Text = "number of items added = " + ListBox1.Items.Count.ToString();
                            numberItems = ListBox1.Items.Count;
                            Session["items"] = ListBox1.Items; //add listbox items to session variable.
                            Session["list"] = items;
                            ListBox1.DataSource = items;
                            ListBox1.DataBind();
                        }
                    }
                }             
            }
            //text for 
            // TextPlacement();
            else// if the page is reloading, (posting more than one time)
            {
                lstSurveyNum = (List<int>)Session["lstSurveyNum"];
                lstSurvey = (List<string>)Session["lstSurvey"];

                //there is a problem with selecting the index in listbox.
                items = (List<ListItem>)Session["list"];
                //ListItemCollection collection = (ListItemCollection)Session["items"];
                for( int i = 0; i < items.Count; i++ )
                {
                    ListBox1.Items.Add(items[i]);
                }
            }
            //making list 
            if (!Page.IsPostBack)
            {
                lst = new List<RadioButtonList>();
                lst.Add(RBListFriend);
                lst.Add(RBLComfort);
                lst.Add(RBLNoise);
                lst.Add(RBLCleanliness);
                lst.Add(RBLSpace);
                              
            } 
            if (!Page.IsPostBack)// this is the 1st
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].Items.Add("No Opinion");
                    lst[i].Items.Add("Poor");
                    lst[i].Items.Add("Fair");
                    lst[i].Items.Add("Good");
                    lst[i].Items.Add("Excelent");
                    lst[i].SelectedIndexChanged += Unnamed_SelectedIndexChanged;
                }
            }
    
        }

        protected void Unnamed_SelectedIndexChanged(object sender, EventArgs e)
        {

            RadioButtonList RBlst = (RadioButtonList)sender;
            string criteria = RBlst.ID;   
          

            lstSurvey.Add(RBlst.SelectedItem.Text);
            lstSurveyNum.Add(RBlst.SelectedIndex);
            Session["lstSurveyNum"] = lstSurveyNum;
            Session["lstSurvey"] = lstSurvey;

        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
           // String s = (String)Session["LB"];
           //lblSurvey.Text = "num elelemnts = " + numberItems.ToString();
        }

        protected void Get_Survey(object sender, EventArgs e)
        {

            lstSurvey = (List<string>)Session["lstSurvey"];
            lstSurveyNum = (List<int>)Session["lstSurveyNum"];
            // lblSurvey.Text = lstSurvey.Count.ToString();
            lblSurvey.Text = "|";
            for(int i = 0; i < lstSurvey.Count; i++)
            {
                lblSurvey.Text += lstSurvey[i].ToString() + " " + lstSurveyNum[i].ToString() + "|";
            }
            //TODO: put it in a survey table.
           // string query = "select * from ";


           // lblSurvey.Text = SandBox();

            /*             create table survey
			(
				review_num int primary key,
				flight_num int not null,
				friendliness int not null,
				space int not null,
				confort int not null,
				cleanliness int not null,
				noise int not null,
				review_optional Text
				);
             
             */

        }
    }
}