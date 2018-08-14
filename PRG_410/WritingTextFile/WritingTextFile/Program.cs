using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WritingTextFile
{
    class ConfigFileParser
    {
        static bool ValueIsIPV4(string accepted)
        {
            bool result = false;
            string pattern = @"^\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}$";
            RegexOptions options = RegexOptions.Singleline;
            MatchCollection collection = Regex.Matches(accepted, pattern, options);
            if(collection.Count != 1)
            {
                result = true;
            }
            return result;
        }
        static bool ValueIsURL(string accepted)
        {
            bool result = false;
            string pattern = @"^(http:\/\/ www\.| https:\/\/ www\.| http:\/\/| https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})? (\/.*)?$";
            RegexOptions options = RegexOptions.Singleline;
            MatchCollection collection = Regex.Matches(accepted, pattern, options);
            if (collection.Count != 1)
            {
                result = true;
            }
            return result;
        }
        static bool ValueIsLocalHost(string accepted)
        {
            bool result = false;
            string pattern = @"^(l|L)(o|O)(c|C)(a|A)(l|L)(h|H)(o|O)(s|S)(t|T)$";
            RegexOptions options = RegexOptions.Singleline;
            MatchCollection collection = Regex.Matches(accepted, pattern, options);
            if (collection.Count != 1)
            {
                result = true;
            }
            return result;
        }

        public bool Extraction(string accepted)
        {
            return accepted.ToLower() == "localhost";             
        }


        static string[] Process(string filename) 
        {
           
            StreamReader file = new StreamReader(filename);
            if(file == null)
            {
                string msg = "file missing";
                throw new ConfigFileException(msg);
            }


            string line;
            int counter=0;
            string[] output = new string[5];//chose 5 because that is how many are in the text file.

            string pattern = @"^[a-zA-Z0-9_ ]*=[a-zA-Z0-9_ ]*$";

            RegexOptions options = RegexOptions.Singleline;
            int regex_count = 0;

            while((line = file.ReadLine())!= null)
            {       
                string inpute = line;
                MatchCollection collection = Regex.Matches(inpute, pattern, options);
                counter++;
                if(collection.Count != 1)
                {
                    Console.WriteLine("there was nothing read that fits pattern.");
                    break;
                }
                else
                {
                    Match m = collection[0];
                    string value = inpute.Substring(inpute.LastIndexOf('='));  //gets right hand side of equal sign in txt file.
                    if (counter == 1)
                    {
                        //this is where we will perform 2 additional checks.
                        //for the case the etry processed is the data source
                        //either ip address or a domain name.
                        bool IPV4false = ValueIsIPV4(inpute);    //if the right hand side has 4 periods.
                        bool URLFalse = ValueIsURL(inpute);
                        bool LocalHostFalse = ValueIsLocalHost(inpute);

                        if (IPV4false && URLFalse && LocalHostFalse)
                        {            // nothing matched the regex's so they typed something in wrong format, so throw exception
                            string msg ="";
                            if (IPV4false == false)
                            {   //url and ip does not exist.

                                msg += "Not a IPV";
                            }

                            if (URLFalse == false)
                            {   //url and ip does not exist.

                                msg += "Not a URL";
                            }

                            if(LocalHostFalse == false)
                            {
                                msg += "Not a LocalHost";
                            }
                            throw new ConfigFileException(msg);
                        }
                        else
                        {
                            //we match at least 1 of the 3 regex..., so its a correct formatted datasource
                        }

                    }

                    output[counter] = value;//we used counter to set up iteration through the number slot of output array.
                    regex_count++;
                }
   
                counter++;
            }
            if(regex_count == 5)
            {
                Console.WriteLine("we have found all the lines in the text file.");
            }
            else
            {
                string msg = "Data Inconsistant";
                throw new ConfigFileException(msg);
            }
            file.Close();
            return output;
        } 
        
    }
}
