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
		public static extern bool GetCursorPos(out Point lpPoint);

		protected MousePos()
		{
			
		}
		public static Point GetMousePossition()
		{
			Point lpPoint;
			GetCursorPos(out lpPoint);
			return lpPoint;
		}
		
	}
}
