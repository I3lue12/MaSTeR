using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace Week3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sample.txt";
            if(File.Exists (fileName))
            {
                Console.WriteLine("The File name: {0}", fileName);
                Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName));
                Console.WriteLine("Created: {0}",File.GetCreationTime(fileName));

                DirectoryInfo dir = new DirectoryInfo(".");
                Console.WriteLine("\nUsing Foreach: ");
                foreach(FileInfo nfo in dir.GetFiles("*.*"))
                {
                    Console.WriteLine(nfo.Name);
                }
                Console.WriteLine("\nWithout useing foreach");


                FileInfo[] allTheFiles = dir.GetFiles("*.*");
                int numFiles = dir.GetFiles("*.*").Length;
                for(int i = 0; i < numFiles; i++)
                {
                    Console.WriteLine(allTheFiles[i].Name);
                }
            }
            else
            {
                Console.WriteLine("No file exists");
            }
            Console.ReadLine();
        }
    }
}
