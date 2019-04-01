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
					DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);

					FileInfo[] filesInDir = di.GetFiles("*.txt");
 
					foreach(FileInfo somefile in filesInDir)
					{
						string fi = somefile.FullName;
						fullDirectPath.Add(fi);
						lbViewFiles.Items.Add(fi);
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
								//string toEnc = rdr.ReadToEnd();
								while(!rdr.EndOfStream)
								{
									string toenc = rdr.ReadLine();
									lbViewFiles.Items.Add(toenc);
									//toEnc = "GOOlgriN4wXaz5JMf30d09fkvPmAxN8fmnab4sYx3gQ=";
									encoded.Add(Decrypt.Run(toenc));
								}	
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
			
			
			List<string> sepperateList = new List<string>(); //TODO: check Delete or not
			List<string> addOuterEncode = new List<string>();
			List<string> addInnerEncode = new List<string>();

			foreach (string encr in encoded)
			{
				string[] sepperates = new string[] { };
				string[] pattern1 = new string[] { "$~$~$" };  //outer
				sepperates = encr.Split(pattern1, StringSplitOptions.None);
				for(int i = 0; i < sepperates.Length; i++)
				{
					addOuterEncode.Add(sepperates[i]);
				}
				
			}
			
			foreach (string sep in addOuterEncode)
			{
				string[] sepperates2 = new string[] { };
				string[] pattern2 = new string[] { "~$~$~" };
				sepperates2 = sep.Split(pattern2, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < sepperates2.Length; i++)
				{
					addInnerEncode.Add(sepperates2[i]);
				}
			}
	 
			
			//DEBUG
	
			lbViewFiles.Items.Add(saveStates.Count);
			lbViewFiles.Items.Clear();
			for (int i = 0; i< addInnerEncode.Count-4; i+=4)
			{
				Point p = new Point();
				long insertLong = Convert.ToInt64(addInnerEncode[i]);
				string insertKP = addInnerEncode[i + 1];
				p.X = Convert.ToInt32(addInnerEncode[i + 2]);
				p.Y = Convert.ToInt32(addInnerEncode[i + 3]);
				SaveState savestate = new SaveState(insertLong, insertKP, p);
				saveStates.Add(savestate);
			}

			foreach (SaveState st in saveStates)
			{
				lbViewFiles.Items.Add(st.TimeGet.ToString()+" "+ st.KeyboardClick +" "+ st.MousePossition.X.ToString() +" "+ st.MousePossition.Y.ToString());
			}

			//TODO: Run playfunction
			Play play = new Play();
			play.Run(saveStates);
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
