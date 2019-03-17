using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Forms;

namespace ConsoleApp1
{
	public class NewHook  //works
	{
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
		

		public string RunNewHook()
		{
			foreach (System.Int32 i in Enum.GetValues(typeof(Keys)))
			{
				if (GetAsyncKeyState((Keys)i) == -32767)
				{
					//To get key name with Enum.GetName(typeof(Keys), i) 
					// Now you have the pressed key


					//types are of ascii
					//Console.Write(Enum.GetName(typeof(Keys), i) + " " + i.GetType()+ " " + i + "\n");
					Console.Write(Enum.GetName(typeof(Keys), i));

					return Enum.GetName(typeof(Keys), i);
					
				}
				//this displays every key available
				//Console.Write(Enum.GetName(typeof(Keys), i));
			}
			//return nothing if nothing is pressed
			return "";

		}
		/* brefore messing with code
		public void RunNewHook()
		{
			foreach (System.Int32 i in Enum.GetValues(typeof(Keys)))
			{
				if (GetAsyncKeyState((Keys)i) == -32767)
				{
					//To get key name with Enum.GetName(typeof(Keys), i) 
					// Now you have the pressed key


					//types are of ascii
					Console.Write(Enum.GetName(typeof(Keys), i) + " " + i.GetType() + " " + i + "\n");

				}
				Console.Write(Enum.GetName(typeof(Keys), i));
			}
		}
		*/

	}	
}
