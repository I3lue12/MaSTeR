using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaProgram
{
    public partial class MediaProgram : Form
    {
        public MediaProgram()
            {
                InitializeComponent();
            }

        private void Talk(string whatToSay)
        {
			


        }
            private void MediaProgram_Load(object sender, EventArgs e)
            {

            }
        private void searchMedia_Click(object sender, EventArgs e)
            {
                //Button for searching for the media on computer.
                frmVideo Video = new frmVideo();
                Video.Show();
            }

        private void dropPlay_Paint(object sender, PaintEventArgs e) 
            {
                //User drags file or files here to be read, to play either a movie/picture/music and send them to there form

            }
        

        private void textBox1_TextChanged(object sender, EventArgs e)//text box that tells the user what to do at start of screen to play media
            {

            }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)//not sure what this is..
            {

            }

        private void dropPlay_MouseEnter(object sender, EventArgs e)
            {
                Text = "Mouse just entered the Panel";
                Cursor= Cursors.Cross;
            }

        private void dropPlay_MouseLeave(object sender, EventArgs e)
            {
                Text = "Mouse just left";
                Cursor = Cursors.Default;
            }

        private void dropPlay_MouseMove(object sender, MouseEventArgs e)
            {
                Text = "X: " + e.X + ", Y: " + e.Y;
            }

        
    }
}
