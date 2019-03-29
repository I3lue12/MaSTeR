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
using System.Diagnostics;

namespace Replay
{
	public partial class Form1 : Form
	{
		Label lbInstruct = new Label();
		string filePath;
		List<string> fileAppend = new List<string>();
		List<string> fullDirectPath = new List<string>();
		List<SaveState> saveStates = new List<SaveState>();
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
							paths.Add(Path.GetFileName(s));   //adds all txt files in directory to list.
							fullDirectPath.Add(Path.Combine(Path.GetDirectoryName(s),Path.GetFileName(s)));
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
			int exTimer = 2;
			lbViewFiles.Items.Clear();
			lbViewFiles.Hide();
			btnOpenFile.Hide();
			List<string> encoded = new List<string>(); ;
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
			if(fullDirectPath.Count > 0)
			{
				  
				foreach(string s in fullDirectPath)
				{
					if(s.Contains(".txt"))
					{
						//TODO: Run decrypt
						//read file and see if encryption works.
						using (StreamReader rdr = new StreamReader(s))
						{  //try encryptiong
							try
							{
								string toEnc = rdr.ReadToEnd();
								toEnc = "GOOlgriN4wXaz5JMf30d09fkvPmAxN8fmnab4sYx3gQ=";
								encoded.Add(Decrypt.Run(toEnc));
							}
							catch	  //catch
							{
								if(rdr != null)
								{
									//send to list
									encoded.Add("NOT-ENCRYPTED"+s+"NOT-ENCRYPTED");
								}
							}
						}
					}
				}
			}
			else
			{
				encoded.Add("failed");
			}
			//seperate encrypted data
			string[] sepperates=new string[] { };
			List<string> sepperateList = new List<string>(); //TODO: check Delete or not
			foreach (string encr in encoded)
			{
				string[] pattern = new string[] { "~$~$~" };
				sepperates = encr.Split(pattern, StringSplitOptions.None);
			}
			int count = 0;
			for(int i = 0; i < (sepperates.Length/4)-4; i++)
			{
				Stopwatch stopWatch = new Stopwatch();
				long time = 0L;
				string character = "";
				Point point = new Point();					  
				if (sepperates[i+count]==sepperates[i+count]) 
				{    
					time = Convert.ToInt64(sepperates[i + count]); 
				}
				else if(sepperates[i+1+count]== sepperates[i + 1 + count]) 
				{   
					character = sepperates[i + 1 + count];
				}
				else if(sepperates[i+2+count]==sepperates[i+2+count]) 
				{    
					point.X = Convert.ToInt32(sepperates[i + 2 + count]);
				}
				else if(sepperates[i + 3 + count]==sepperates[i + 3 + count]) 
				{     
					point.Y = Convert.ToInt32(sepperates[i + 3 + count]);
				}
				else
				{
					//error
				}
				SaveState savestate = new SaveState(time,character,point);
				saveStates.Add(savestate);
				count += 3;
			}


			foreach(SaveState st in saveStates)
			{
				lbViewFiles.Items.Add(st.TimeGet.ToString());
				lbViewFiles.Items.Add(st.KeyboardClick);
				lbViewFiles.Items.Add(st.MousePossition.X.ToString());
				lbViewFiles.Items.Add(st.MousePossition.Y.ToString());
			}


			//if 0,4,8,12,16,20 //time in miloseconds
			//if 1,5,9,13,17,21 //keypress
			//if 2,6,10,14,18,22	//x posistion
			//if 3,7,11,15,19,23/yposistion	 







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
			//MessageBox.Show(filePath);
			lbInstruct.Text = string.Format("Play: {0}" , filePath.ToString());	
		}
	}
}
