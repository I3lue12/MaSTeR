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
            m_label_first_name.Text = "changed text in label";

            int xCord, yCord;
           
            xCord = Convert.ToInt32(xCordInput.Text);
            yCord = Convert.ToInt32(yCordInput.Text);

            this.Location = new Point(xCord,yCord);
        }
    }
}
