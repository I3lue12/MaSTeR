using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
	public class EventCollection
	{

	
		static string KeyPressTHIS;
		static bool lower = true;
		static List<string> Keys = new List<string>();

		//Dylans way
		static NewHook n = new NewHook();


		public EventCollection()
		{
			
											 
		}

		private static void Tmr_Tick(object sender, EventArgs e)
		{  //every interval gets keypress

		
		}
		//TODO:We will use this
		public static void Run()
		{
			
			
			n.RunNewHook(); //works
			

		}

	
		//TODO: might not need
		private static void Tmr_Elapsed(object sender, ElapsedEventArgs e)
		{
			//n.RunNewHook();
			
		}
	}
}
