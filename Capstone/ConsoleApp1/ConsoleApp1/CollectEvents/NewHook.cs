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
	public class NewHook  
	{
		//http://www.webtropy.com/articles/art9-2.asp?lib=user32.dll
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
		
		public static string RunNewHook()
		{
			foreach (System.Int32 i in Enum.GetValues(typeof(Keys)))
			{
				if (GetAsyncKeyState((Keys)i) == -32767)
				{
					#region Description: i,keys
					//To get key name with Enum.GetName(typeof(Keys), i) 
					// Now you have the pressed key
					//types are of ascii
					//Console.Write(Enum.GetName(typeof(Keys), i) + " " + i.GetType()+ " " + i + "\n");
					//Console.Write(Enum.GetName(typeof(Keys), i));
					#endregion
					return Enum.GetName(typeof(Keys), i);
				}
				//this displays every key available
				//Console.Write(Enum.GetName(typeof(Keys), i));
			}
			//return nothing if nothing is pressed
			return "?";

		}
	}	
}
