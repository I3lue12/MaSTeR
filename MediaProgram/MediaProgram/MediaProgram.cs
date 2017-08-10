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
        private void dropPlay_Paint(object sender, PaintEventArgs e) 
        {
            //User drags file or files here to be read, to play either a movie/picture/music and send them to there form

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //sends user to the form orginizer and that has playlist in there so you could arange how to play the media.

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
