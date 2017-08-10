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

        private void MediaProgram_Load(object sender, EventArgs e)
            {

            }
        private void searchMedia_Click(object sender, EventArgs e)
            {
                //Button for searching for the media on computer.
            }

        private void dropPlay_Paint(object sender, PaintEventArgs e) 
            {
                //User drags file or files here to be read, to play either a movie/picture/music and send them to there form

            }
        

        private void textBox1_TextChanged(object sender, EventArgs e)//text box that tells the user what to do at start of screen to play media
            {

            }

        
    }
}
