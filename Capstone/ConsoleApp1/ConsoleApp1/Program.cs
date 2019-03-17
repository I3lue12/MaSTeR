using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;

namespace ConsoleApp1
{
	class Program		   
	{
		static System.Threading.Timer tmr;
		static Stopwatch stpWatch;
		//https://www.dotnetperls.com/stopwatch


		static void Main(string[] args)
		{

			//tmr = new System.Threading.Timer(DisplayTimeEvent,null,0,100);
			
			//EventCollection.Run();

			//tmr.Dispose();
			//Console.WriteLine("\nDestroying timer.");

			stpWatch = new Stopwatch();
			stpWatch.Start();
			long timespan = stpWatch.ElapsedMilliseconds;
			while(timespan < 1800000)
			{
				EventCollection.Run();
			}

			Console.ReadKey();
		}
		private static void DisplayTimeEvent(Object o)
		{
			// Display the date/time when this method got called.
			Console.WriteLine("In TimerCallback: " + DateTime.Now);

			// Force a garbage collection to occur for this demo.
			//GC.Collect();
		}
	}
}
