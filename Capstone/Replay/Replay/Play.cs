using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Replay
{
	public class Play:Form1
	{
		private Button btn = new Button();

		const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
		const uint MOUSEEVENTF_LEFTUP = 0x0004;
		private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
		private const int MOUSEEVENTF_RIGHTUP = 0x10;

		bool mouseUp = true;

		[DllImport("user32.dll")]
		static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData,
										int dwExtraInfo);


		public Play()
		{

		}
		public void Run(List<SaveState> ListSaveState)
		{
			//get access to all events
			bool firststart = true;
			int count = ListSaveState.Count;
			while (count > 0)
			{
				//System.Threading.Thread.Sleep(10);//control speed

				foreach (SaveState s in ListSaveState)
				{
					//go to mouse possition x and u
					//need to design a way to read the individual keys vs the enter,shift, ect...
					
					//mouseposistion
					System.Threading.Thread.Sleep(75);
					Point p = new Point();
					p.X = s.MousePossition.X;
					p.Y = s.MousePossition.Y;
					Cursor.Position = p;

					if (s.KeyboardClick == "LButton")
					{
						DoMouseClick();
					}
					if (s.KeyboardClick.Length < 2)
					{
						SendKeys.Send(s.KeyboardClick);

					}
					else if(s.KeyboardClick == "NKC")
					{

					}
					else if(s.KeyboardClick == "Enter")
					{

					}
					else
					{
						
					}
					count--;
				}
				
			}
		}
		public void DoMouseClick()
		{
			//Call the imported function with the cursor's current position
			int X = Cursor.Position.X;
			int Y = Cursor.Position.Y;
			mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
			mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
			
		}
	}
}
