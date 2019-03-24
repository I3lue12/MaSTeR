using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Runtime.InteropServices;
namespace ConsoleApp1
{
	class MousePos
	{
		[DllImport("user32.dll")]
		private static extern bool GetCursorPos(out Point lpPoint);

		protected MousePos()
		{
			
		}
		public static Point GetMousePossition()
		{
			Point lpPoint;
			if (GetCursorPos(out lpPoint))
			{
				return lpPoint;
			}
			else
			{
				return new Point(0, 0);
			}
		}
		
	}
}
