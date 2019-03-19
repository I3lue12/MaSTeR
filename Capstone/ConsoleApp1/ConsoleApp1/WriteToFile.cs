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
		protected WriteToFile()
		{

		}
		public static void Run(string toFile)
		{
			//make directory for file
			//get where this program is.
			


			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
			path= AppDomain.CurrentDomain.BaseDirectory;
			path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();// two directors up
			string appendPath = "RecordPath";
			path = Path.Combine(path, appendPath);
			if (!Directory.Exists(path))//check to see if a directorys exist.
			{
				Directory.CreateDirectory(path);
			}
			if(Directory.Exists(path))
			{
				//TODO:Search Function to make seperate setions each time the program starts.
				appendPath = "Session.txt";
				path = Path.Combine(path, appendPath);
				//if (!File.Exists(path))
				//{

				//}
				using (StreamWriter sw = new StreamWriter(path, true))//auto makes the file if not found
				{
					sw.WriteLine(toFile);
				}
			}
			
			//for(int i =0; i < path.Length; i++)
			//{
			//	if(path[i] == 'b')
			//	{
			//		if(path[i+1] == 'i')
			//		{ 
			//			if (path[i+2] == 'n')
			//			{
			//			   for(int j =0; j < path.Length-path[i];j++)
			//				{
			//					break;
			//				}
			//			}
			//		}
			//	}
			//}
			Console.WriteLine("DEBUG:DEBUG: " + path);
			//make file of type txt. 
			//add string toFile to txt file then close

		}
	}
}
