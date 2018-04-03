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
    public partial class frmVideo : Form
        {
			public string nameFrommom;
			public string nameFromVideo;

			private MediaProgram Mom;//mental note who mother is
			

			public void userChoseSetting(string setting)//setting remembering
			{
				Text = setting;
			}

			public frmVideo(MediaProgram parent)
			{
				Mom = parent;
				
				nameFrommom = "Blau";
				InitializeComponent();
			}

			private void frmMediaProgram_Click(object sender, EventArgs e)
			{
				
				Mom.Show();
				Mom.Display();
				this.Hide();

			}

			public void Setting_Click(object sender, EventArgs e)
			{
				frmSetting frm = new frmSetting(this);
				frm.Show();

				this.Hide();
				
			}

			private void mediaNav_SelectedIndexChanged(object sender, EventArgs e)
			{
				//I have made a Music, Photos, and Settings drop down. This will be standard throught all mediaProgram
			}

			private void videoPlayList_SelectedIndexChanged(object sender, EventArgs e)
			{
				//I want to make this the playlist that is shown in "minimized mode" 
				// It lists the items that were dragged into the media player, and play in order by default Name or ABC order.
				//make it so that you can customize the list of what to play next or by deleting. 
			}
        }
    }
