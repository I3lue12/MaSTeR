using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Replay
{
	public class SaveState
	{
		private string keyBoardClick;
		private long time = 0;
		private Point mousePosistion;

		public SaveState(long time, string keyboardclick, Point mousepos)
		{
			this.time = time;
			keyBoardClick = keyboardclick;
			mousePosistion = mousepos;
		}
		public long TimeGet { get { return this.time; } }
		public string KeyboardClick { get { return this.keyBoardClick; } }
		public Point MousePossition { get { return this.mousePosistion; } }
	}
}
