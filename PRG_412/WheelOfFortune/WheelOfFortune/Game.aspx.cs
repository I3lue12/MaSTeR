using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Game : System.Web.UI.Page
{
    private string[] words = { "Michael", "Justin", "Strawberry", "Blonde", "Kraeer", "Henderson", "Greer", "CCSD", "USMC", "Army", "Navy", "Chair Force"
                             , "Denver", "Broncos", "Foti", "Fudge", "Packers", "Wounded", "Warrior", "Everywhere", "Green", "Lantern", "Business", "suit",
                             "Tshirt", "Pants", "Dinosaur", "Apple", "IWatch", "Inconceivable", "Ipod", "maxipad", "Ipad", "Iphone", "Class", "Orange", "Juice",
                             "Network", "Security", "Guide", "Information", "Marriage", "Kid", "Visual", "Studio", "tie", "glitch", "hand", "penis", "sky",
                             "Vanilla", "coconut", "back", "broken", "disability", "rack", "spoken", "lie", "band", "orange", "apple", "strawberry", "blueberry", "peach",
                             "banana", "watermelon", "melon", "onion", "dance", "parfait", "zucchini", "pea", "soy", "sauce", "carrot", "shrimp", "pepper", "salt",
                             "rice", "noodle", "spaghetti", "red", "marinara", "alfredo"};

    protected string hidden;

    protected void Page_Load(object sender, EventArgs e)
    {   //phace a
        if(Session["user"] == null)         //bouncer check
        {
            Response.Redirect("Login.aspx");
        }
        if(!IsPostBack)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, words.Length); //random dice role in the array of words.
            GameInfo g = new GameInfo();
            g.Hidden = words[r]; //get the hidden word at possistion r
     
            tbHidden.Text = "";
            for (int i = 0; i < g.Hidden.Length; i++)
            {
                tbHidden.Text += "*";
            }
            g.TriesRemaining = 2 * g.Hidden.Length;
            Session["hiddenWord"] = g;
        }
    }

    protected void btnGameGuess_Click(object sender, EventArgs e)
    {//phace b
         
        if (tbGameCharaGuess.Text.Length == 1)
        {
            char c = tbGameCharaGuess.Text[0];
            GameInfo gi = (GameInfo)Session["hiddenWord"];
            gi.Attempts.Add(c);
            gi.TriesRemaining--;
            Session["hiddenWord"] = gi;
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {   //phace c
        UserInfo ui = (UserInfo)Session["user"]; //passed user info to 
        lblGameUser.Text = "Hello, " + ui.Username + "!";

        GameInfo gi = (GameInfo)Session["hiddenWord"];
        lblGameReGuesses.Text = "Tries remaining: " + gi.TriesRemaining;
        tbGameGuessesMade.Text = "";
        foreach(char c in gi.Attempts)
        {
            tbGameGuessesMade.Text += c + ", ";  
        }
    }

    protected void btnGameLogout_Click(object sender, EventArgs e)
    {//phace b
        Session["user"] = null;
        Response.Redirect("Login.aspx");
    }
   
}