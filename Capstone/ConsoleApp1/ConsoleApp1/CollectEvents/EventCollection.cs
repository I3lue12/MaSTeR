using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;
using System.Diagnostics;

namespace ConsoleApp1
{
	public class EventCollection
	{
		 

		static SaveState saveState;

		EventCollection() { }					 
		
		public static SaveState Run(Stopwatch stpWatch)
		{
			return saveState = new SaveState(stpWatch.ElapsedMilliseconds, RunKBHook(), RunMP());
		}
		
		protected static string RunKBHook()
		{
			 return NewHook.RunNewHook(); 
		}

		protected static Point RunMP()
		{
			return MousePos.GetMousePossition(); 
		}
	}
}
