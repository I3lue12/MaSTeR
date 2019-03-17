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
		static SaveState saveState;
		const long MaxTime = 1800000;

		static void Main(string[] args)
		{

			
			stpWatch = new Stopwatch();
			stpWatch.Start();
			long timespan = stpWatch.ElapsedMilliseconds;
			while(timespan < MaxTime) //30 minutes	//could just make a boolian
			{
				//EventCollection.RunKBHook();
				//EventCollection.RunMP();
				//Console.WriteLine(EventCollection.RunMP().X + " | " + EventCollection.RunMP().Y);
				saveState = new SaveState(stpWatch.ElapsedMilliseconds, EventCollection.RunKBHook(), EventCollection.RunMP());
				Console.WriteLine(saveState.time + " | " + saveState.keyBoardClick + " | " + saveState.mousePosistion.X + " | " + saveState.mousePosistion.Y);
				Thread.Sleep(100);				
				//TODO: Ecrypt data file
				//TODO: Write to file


				if (timespan == 1799999)//might need to give leway
				{
					stpWatch.Reset();
				}

			}

			Console.ReadKey();
		}
	}
}
