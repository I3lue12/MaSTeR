using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;

namespace ConsoleApp1
{
	public class EventCollection
	{

	
		static string KeyPressTHIS;
		static bool lower = true;
		static List<string> Keys = new List<string>();

		//Dylans way
		static NewHook n = new NewHook();
		static MousePos mp;
		
		EventCollection()
		{
			
											 
		}
	
		//TODO:We will use this
		public static string RunKBHook()
		{
			 return n.RunNewHook(); //works

		}
		public static Point RunMP()
		{
			return MousePos.GetMousePossition(); //works
		}
	}
}
