using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Week_One_PRG321 : Form
    {
        public Week_One_PRG321()
        {
            InitializeComponent();
            feedback.Text = "place cordinates in text boxes to cahnge possition. Only whole numbers please.";
            
        }

        private void newPos_Click(object sender, EventArgs e)
        {
            m_label_first_name.Text = "Enter in other Places I can be.";

            int xCord, yCord;
           
            //use string class propertys to check if space is empty
            if ((String.IsNullOrEmpty(xCordInput.Text)) || (String.IsNullOrEmpty(yCordInput.Text)))
            {
                m_label_first_name.Text = "Go ahead and enter a number.";
            }
            else
            {
                xCord = Convert.ToInt32(xCordInput.Text);
                yCord = Convert.ToInt32(yCordInput.Text);

                // cant go in the negative direction/off screen
                if (xCord < 0 || yCord < 0)
                {
                    feedback.Text = "You need to put in positive number text thing";
                
                }
                else
                {
                    this.Location = new Point(xCord,yCord);
                    feedback.Text = "This is a a nice place to be.";               
                }
            }


        }
    }
}
