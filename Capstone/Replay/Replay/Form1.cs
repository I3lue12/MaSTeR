using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Text;

namespace Replay
{
	public partial class Form1 : Form
	{
		Label lbInstruct = new Label();
		string filePath;

		public Form1()
		{
			InitializeComponent();
			string somethign = "";
			lbViewFiles.Items.Add(somethign);
			lbViewFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.Controls.Add(lbInstruct);

			lbInstruct.Show();
			lbInstruct.Text = "asdfasdf";
			lbInstruct.Left = this.Width / 2;
			lbInstruct.Top = this.Height / 2;		
			//lbInstruct.Visible = false;
			lbInstruct.Visible = true; //DELETE
			lbInstruct.Left = 10;
			lbInstruct.Top = 10;
			lbInstruct.Width = 1000; //bain of my exISTANCE
			
		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			//OpenFileDialog openFile = new OpenFileDialog();

			//openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					lbViewFiles.Items.Clear();
					string[] files = Directory.GetFiles(fbd.SelectedPath);
					string[] direct = Directory.GetDirectories(fbd.SelectedPath);
					List<string> paths = new List<string>();
					foreach (string s in files)
					{
						if (Path.GetFileName(s).Contains(".txt"))
						{
							lbViewFiles.Items.Add(Path.GetFileName(s));
							paths.Add(Path.GetFileName(s));	  //adds all txt files in directory to list.
						}
					}
					foreach (string d in direct)
					{
						lbViewFiles.Items.Add(Path.GetDirectoryName(d)); //adds to view the direcotrys in selected direcotory.
					}
				}
			}


			//using (OpenFileDialog openFile = new OpenFileDialog())
			//{

			//	openFile.InitialDirectory = "c:\\";

			//	if (openFile.ShowDialog() == DialogResult.OK)
			//	{
			//		string fileLoc = openFile.FileName;
			//		string direct = Path.GetDirectoryName(fileLoc);
			//		//grab file location
			//		lbViewFiles.Items.Add(direct);

			//	}
			//}
			
		}

		private void lbViewFiles_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = (int)e.Graphics.MeasureString(lbViewFiles.Items[e.Index].ToString(), lbViewFiles.Font, lbViewFiles.Width).Height;
		}
	

		private void lbViewFiles_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.DrawFocusRectangle();
			e.Graphics.DrawString(lbViewFiles.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int exTimer = 10;
			lbViewFiles.Hide();
			btnOpenFile.Hide();

			while (exTimer > 0)
			{
				lbInstruct.Visible = true;
				lbInstruct.Text = string.Format("Dont touch program: {0}", exTimer);
				this.Update(); //repaint.
				Thread.Sleep(1000);
				exTimer -= 1;
			}
			this.Hide();
			//TODO: Run grab file.
			//TODO: Run decrypt
			//TODO: Run playfunction
			


			//bring back the program
			this.Show();
			lbViewFiles.Show();
			btnOpenFile.Show();
			this.Visible = true;
		}

		private void lbViewFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			//filePath = lbViewFiles.GetItemText(lbViewFiles.SelectedItem);
			
			filePath = lbViewFiles.SelectedItem.ToString();
			string ccc="";
			foreach(char c in filePath)
			{
				ccc += c.ToString();
			}
			MessageBox.Show(filePath);
			//lbInstruct.Text = "Clicked";
			lbInstruct.Text = string.Format("Play: {0}" , filePath.ToString());
			//lbInstruct.BringToFront();
			//this.Update();
			
		}
	}
}
