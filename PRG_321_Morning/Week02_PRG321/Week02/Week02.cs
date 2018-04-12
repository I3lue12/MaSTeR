using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    public partial class Week02 : Form
    {
        Coach Coach1;
        Coach Coach2;
        SportTeam st1,st2,st3,address;
        public string newaddress = "newplaceyo";
        public Week02()
        {
            InitializeComponent();

            Coach1 = new Coach();
            Coach1.FirstName = "Brendon";
            Coach1.LastName = "Blau";

            Coach2 = new Coach(Coach1);

            st1 = new SportTeam();          

            st2 = new SportTeam_Football();//override sportsteam class with football
            
            st3 = new SportTeam_Tennis();//override sportsteam class with tennis.
            address = new SportTeam_Football();

        
            address.DisplaySportsLocation("somthing");
            



            label1.Text = Coach2.ToString();



            label2.Text = st1.DisplaySportsTeam() + " Located: " + address.DisplaySportsLocation("Florida") + "\n " + st2.DisplaySportsTeam() + " " + st3.DisplaySportsTeam();
        }
    }
}
