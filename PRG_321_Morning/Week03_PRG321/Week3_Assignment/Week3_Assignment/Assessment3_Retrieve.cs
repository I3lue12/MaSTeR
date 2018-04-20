using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Week3_Assignment
{
    /*
     unsafe struct Record //structure is like 
    {

        String FirstName;
        String LastName;
        double[] scores = new double[3];

    }
    */
    public class Assessment3_Retrieve
    {
        
        public static void Run()
        {
            /*
            String FirstName;
            String LastName;
            double[] scores = new double[3];
            */
        StreamWriter streamWriter = new StreamWriter("record.txt");

            streamWriter.WriteLine("brendon blau 66.0 93.0 55.5");
            streamWriter.WriteLine("julien esposito 77.0  84.0   69.0");
            streamWriter.WriteLine("Jorden gross  48.0  96.00     100.0");
            streamWriter.Close();//need to close or will lose everything.

            String buffer = String.Empty;
                    StreamReader streamReader = new StreamReader("record.txt");
                    string readFirstLine, readSecondLine, readThirdLine, readFourthLine;
                    double firstNumber;

            readFirstLine = streamReader.ReadLine();
            readSecondLine = streamReader.ReadLine();
            readThirdLine = streamReader.ReadLine();
            readFourthLine = streamReader.ReadLine();
            //firstNumber = readFirstLine.

            Console.WriteLine(readFirstLine);
            Console.WriteLine(readSecondLine);
            Console.WriteLine(readThirdLine);
            // Console.WriteLine(readFourthLine);

            //double stringLength = Convert.ToDouble(readFirstLine);


            
            string storedNumber = "";
            string string1, string2, string3;
            int parsed1, parsed2, parsed3;
            double totl;
            List<string> numberInText = new List<string>();
            List<int> addingParsed = new List<int>();

            //this checks for if there are strings between 0 -9 and adds them to numberInText list collection.
            for (int i = 0; i < readFirstLine.Length; i++)
            {
                if((readFirstLine[i] >= '0')&&(readFirstLine[i] <= '9'))
                {
                    storedNumber = Convert.ToString(readFirstLine[i]);
                    //need a seperation thing/method to keep the intigers/strings in 3s. ex. [0,1,2],[3,4,5],[6,7,8];
                    numberInText.Add(storedNumber);
                }
             
                //Console.Write(readFirstLine[i]);
            }
            string1 = numberInText[0] + numberInText[1] + numberInText[2];
            string2 = numberInText[3] + numberInText[4] + numberInText[5];
            string3 = numberInText[6] + numberInText[7] + numberInText[8];
            parsed1 = Int32.Parse(string1);
            parsed2 = Int32.Parse(string2);
            parsed3 = Int32.Parse(string3);
            totl = ((parsed1 + parsed2 + parsed3) / 3);
            //seperate totl into string or chacters then put dot or . just before last one.
            Console.WriteLine(totl);


            //IEnumerable <IGrouping<string,string> query = numberInText.GroupBy(numberInText=>numberInText[0],numberInText=>numberInText[1],numberInText=>numberInText[2]); //ask about

            //notes from microsoft about grouping
            /*
             
                        // Group the pets using Age as the key value 
                        // and selecting only the pet's Name for each value.
                        IEnumerable<IGrouping<int, string>> query =
                        pets.GroupBy(pet => pet.Age, pet => pet.Name);
             */





            //this is to parse everything on first line in file. and add it to collection list.
            /*
            for (int i = 0; i < numberInText.Count; i++)
            {
                addingParsed.Add( Int32.Parse(numberInText[i])); 
            }
            Console.WriteLine(addingParsed.ToString());
            Console.WriteLine(addingParsed.Count);
            for(int i = 0; i < addingParsed.Count; i++)
            {
                int addParse1,addParse2,addParse3;
                addParse1 = addingParsed[0] + addingParsed[1];
                addParse2 = addingParsed[3]+
                //problem adding everything.
            }

            foreach(int n in addingParsed)
            {
                Console.Write(n);
            }
            */

            /*
            //this took the first of the numberInText list and parsed it
            int parseNumberText;
            parseNumberText = Int32.Parse(numberInText[0]);
            Console.WriteLine(parseNumberText  + "Parsed");
            */


            //prints the string of the list 
            /*
            foreach(string n in numberInText)
            {
                Console.Write(n);         
            }
            Console.WriteLine("\n"+numberInText[0]+numberInText[1]+numberInText[2]);
            */

            

                streamReader.Close();

            #region 4-19-2018 printing out to console text from a file.
            /*
              //this is trying to use what was taught in class 4-19-2018
              // this prints out the strings from the record.txt file.
            do
            {
                buffer = streamReader.ReadLine();

                if (null != buffer)
                {

                    int size_string = buffer.Length;
                    int firstDigit = 0;
                    String number = " ";
                    for(int i = 0; i <= size_string; i++)
                    {
                        if((buffer[i] >= '0') && (buffer[i] <='9'))
                        {
                            firstDigit = i;

                            number = buffer.Substring(firstDigit);
                            
                            break;
                        }

                    }
                    Console.WriteLine("Grades = <" + number + ">" + number.Max());
                    
                }
                //TO DO - if check to get numbers.               
            }
            while (buffer != null);
            */

            //foreach (char n in number)
            //{
            //    Console.WriteLine(n.ToString());
            //}
            #endregion

            #region regular expression
            //regular expression
            // string pattern = @"[[:digit:]]+[.](0,1)[[:digit:]](0,5)+";//[a-zA-Z]+[[:blank:]]+[a-z][A-Z]+([[:blank:]]+          

            /*
             //this was taught in class
            do
            {
                buffer = streamReader.ReadLine();

                if (null != buffer)
                {

                    Regex r = new Regex(pattern);
                    MatchCollection matches = r.Matches(buffer);

                    string[] substrings = Regex.Split(buffer, pattern);
                    int count = substrings.Length;
                    Console.WriteLine("split generated " + count + " elements - 1st elements = " + substrings[0]+1);
                    Console.WriteLine("split generated " + matches + " elements - 1st elements = " + matches[0]);
                }
                //TO DO - if check to get numbers.               
            }
            while (buffer != null);
            */



            /*
            foreach(Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0} found at index {1}.", m.Value + m.Index);
            }
            */
            #endregion


            Console.WriteLine("\nTitle: assessment #3");
        }

    }
}
