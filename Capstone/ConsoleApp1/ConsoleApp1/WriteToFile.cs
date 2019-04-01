using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
	public class WriteToFile
	{
		protected WriteToFile() { }

		public static void Run(string toFile)
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();// two directors up
			string appendPath = "RecordPath";
			path = Path.Combine(path, appendPath);
			if (!Directory.Exists(path))//check to see if a directorys exist.
			{
				Directory.CreateDirectory(path);
			}
			else
			{
				
				appendPath = "Session.txt";
				path = Path.Combine(path, appendPath);
				using (StreamWriter sw = new StreamWriter(path, true))//auto makes the file if not found
				{
					sw.WriteLine(toFile);
				}

			}
		}
	}
}
