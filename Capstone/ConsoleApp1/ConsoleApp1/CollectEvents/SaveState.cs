using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
	public class SaveState
	{
		public string keyBoardClick;
		public long time=0;
		public Point mousePosistion;

		public SaveState(long time, string keyboardclick, Point mousepos)
		{
			this.time = time;
			keyBoardClick = keyboardclick;
			mousePosistion = mousepos;
		}
	}
}
