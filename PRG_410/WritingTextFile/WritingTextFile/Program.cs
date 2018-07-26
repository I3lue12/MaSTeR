using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WritingTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                 fs = File.Open(@"C:\Users\CCSDuser\Documents\GitHub\MaSTeR\PRG_410\Week1TXT.txt", FileMode.Open);
            }
            catch(Exception ex)
            {
                Console.WriteLine("opening file problem: " + ex.Message);
            }
            //if past catch block we can start parsing our file

            //byte[] b = new byte[1024];
            //UTF8Encoding temp = new UTF8Encoding(true);

            //while (fs.Read(b, 0, b.Length) > 0)
            //{
            //    Console.Write("<"+ temp.GetString(b)+">");
            //}
            fs.Close();

            StreamReader file = new StreamReader(@"C:\Users\CCSDuser\Documents\GitHub\MaSTeR\PRG_410\Week1TXT.txt");
            string line;
            int counter=0;
            string pattern = @"^[a-zA-Z0-9_ ]*=[a-zA-Z0-9_ ]*$";
            RegexOptions options = RegexOptions.Singleline;
            int regex_count = 0;

            while((line = file.ReadLine())!= null)
            {       
                string inpute = line;
                MatchCollection collection = Regex.Matches(inpute, pattern, options);
                if(collection.Count != 1)
                {
                    Console.WriteLine("there was nothing read that fits pattern.");
                    break;
                }
                else
                {
                    Match m = collection[0];
                    regex_count++;
                }

                //foreach(Match m in Regex.Matches(inpute, pattern, options))
                //{
                //    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                //}

                //System.Console.WriteLine("<" + line + ">");
                counter++;
            }
            if(regex_count == 5)
            {
                Console.WriteLine("we have found all the lines in the text file.");
            }
            file.Close();


            //courtesy of https://regex101.com
            





        }
        
    }
}
