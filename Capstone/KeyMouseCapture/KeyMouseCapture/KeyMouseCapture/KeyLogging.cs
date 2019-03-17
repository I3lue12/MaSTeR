using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;


namespace KeyMouseCapture
{
	public class KeyLogging
	{
		[DllImport("user32.dll")]
		
		public static extern int GetAsyncKeyState(Int32 i);
		static public int sendAssNum = 1;

		public KeyLogging()
		{

		}
		public string LogKeys()
		{
			KeysConverter converter = new KeysConverter();
			string text = "";


			//get the key stroke
			//Thread.Sleep(10);
			for (Int32 i = 0; i < 255; i++)
			{
				//get the key stroke
				int key = GetAsyncKeyState(i);
				if (key == 1 || key == -32767)
				{
					text = converter.ConvertToString(i);
					//send live info into a list.
					sendAssNum = i;
					return text;
					//break;//this will break when it found the key
				}
			}


			//	while (true)//condiction for when to stop recording key strokes
			//	{
			//		Thread.Sleep(10);//why sleep
			//		for (Int32 i = 0; i < 255; i++)
			//		{
			//			//get the key stroke
			//			int key = GetAsyncKeyState(i);
			//			if (key == 1 || key == -32767)
			//			{
			//				text = converter.ConvertToString(i);
			//				//send live info into a list.
			//				sendButton.Add(text);
			//				break;//this will break when it found the key
			//			}
			//		}
			//	}
				return "";
		}
		static public int SendAssNum()
		{
			int temp = sendAssNum;
			return temp;
		}
	}


}
