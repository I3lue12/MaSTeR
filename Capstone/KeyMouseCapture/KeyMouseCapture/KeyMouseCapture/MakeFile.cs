using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyMouseCapture
{
	static public class MakeFile
	{
		public static void MakeSaveState(string saveState, string filePath)
		{
			string path = filePath;
			if (!File.Exists(path))
			{
				using (FileStream fs = File.Create(path))
				{
					File.AppendText(saveState);
				}
			}
			else
			{
				using (FileStream fs = File.Create(path))
				{
					File.AppendText(saveState);
				}
			}
		}
		public static void MakeSaveState(string saveState, string fileName, string fildir)
		{
			try
			{
				Directory.CreateDirectory(fildir);
			}
			finally
			{
				if (!File.Exists(fileName))
				{
					using (FileStream fs = File.Create(fileName))
					{
					
					}
				}
				else  //TODO: Look over this code to see if it will work.
				{
					//this will give a random number assosiated to the file everytime
					Random rnd = new Random();
					int number = rnd.Next();
					fileName = fileName + number.ToString();
					while (File.Exists(fileName + rnd))
					{
						rnd.Next();
						fileName = fileName + rnd;
					}
					using (FileStream fs = File.Create(fileName))
					{

					}
				}
				using (StreamWriter wr = new StreamWriter(fileName))
				{
					wr.WriteLine(saveState);
				}
			}
			string path = fileName;
			
			
		}
	}
}
