using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace Week3_Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //4-17-2018
            #region 4-17-2018

            //string fileName = "sample.txt";
            //if(File.Exists (fileName))
            //{
            //    Console.WriteLine("The File name: {0}", fileName);
            //    Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName));
            //    Console.WriteLine("Created: {0}",File.GetCreationTime(fileName));

            //    DirectoryInfo dir = new DirectoryInfo(".");
            //    Console.WriteLine("\nUsing Foreach: ");
            //    foreach(FileInfo nfo in dir.GetFiles("*.*"))
            //    {
            //        Console.WriteLine(nfo.Name);
            //    }
            //    Console.WriteLine("\nWithout useing foreach");


            //    FileInfo[] allTheFiles = dir.GetFiles("*.*");
            //    int numFiles = dir.GetFiles("*.*").Length;
            //    for(int i = 0; i < numFiles; i++)
            //    {
            //        Console.WriteLine(allTheFiles[i].Name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No file exists");
            //}
            #endregion
            /*
             Write an application that retrieves a student name and 
             three scores per line from a textfile.
             Process the values by calculating the average of the scores per student.
             Write the name and average to a different text file.
             Test your application with a minimum of eight records in the original file.
             
            3 score = 60;
             
            60 per line?
            score as in points.

             Students.txt
             4 lines

             */
            string studentName = "Students.txt";
            StreamReader readFromText = new StreamReader(studentName);



            //Array[] readingFromStudentText = new Array[];

            //Console.WriteLine(readFromText.ReadLine()[0]);

            

            
            //Console.WriteLine(readFromText.ReadToEnd());
            string writeName;
           // Convert.ToInt32(readFromText.Read());
            writeName = Convert.ToString(readFromText.Read());
            Console.WriteLine(writeName);
            readFromText.Close();
            Console.ReadKey();




            StreamWriter writeToText = new StreamWriter(studentName);

            writeToText.WriteLine("Brendon Blau 67");
            writeToText.WriteLine("Tickle me Elmo  95");
            writeToText.WriteLine("Steve Marvin  47");
            writeToText.Close();


            if(File.Exists(studentName))
            {
                Console.WriteLine("file should open");
                Console.WriteLine(File.GetLastAccessTime(studentName));              
            }
            else
            {
                Console.WriteLine("nothing opened");
            }

           // Console.WriteLine(File.OpenRead(studentName));
            //File.Open(studentName, FileMode.Open, FileAccess.Write);

            

                Console.ReadKey();

            #region 4-18-2018
            //    StreamReader inputFile = new StreamReader("numbers.txt");
            //    string content = "";

            //    ArrayList value = new ArrayList();
            //    List<Int32> valuesmax = new List<Int32>();






            //    while(content != null)
            //    {
            //        if(content == null)
            //        {
            //            inputFile.Close();
            //        }
            //        content = inputFile.ReadLine();
            //        try
            //        {
            //            int temp = Convert.ToInt32(content);
            //            value.Add(temp);
            //            valuesmax.Add(temp);
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("error converting to a number from file." + e.Message);
            //                break;
            //        }

            //    }

            //    inputFile.Close();
            //    Console.WriteLine("The array contains " + value.Count + " elements");
            //   // inputFile.Read();

            //    foreach(var numbers in value)
            //    {
            //        Console.WriteLine("Current value: " + numbers);
            //    }
            //    Console.WriteLine(valuesmax.Max());
            //    Console.WriteLine(FindMin(valuesmax));

            //    Console.ReadLine();
            //}
            //public static int FindMin(List<int> input)
            //{
            //    int result = input[0];
            //    for (int i = 0; i < input.Count; i++)
            //    {
            //        result = input[i];
            //    }
            //    return result;
            //}
            #endregion
        }
    }
}
