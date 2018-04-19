using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Week3_Assignment
{
    public class Assignment3_ReadingIntegers
    {
        

        

         public static void Assignment3_ReadingInteger()
        {
            StreamReader inputFile = new StreamReader("numbers.txt");
            string content = "";

            ArrayList value = new ArrayList();
            List<Int32> valuesmax = new List<Int32>();

            while (content != null)
            {
                if (content == null)
                {
                    inputFile.Close();
                }
                content = inputFile.ReadLine();
                try
                {
                    int temp = Convert.ToInt32(content);
                    value.Add(temp);
                    valuesmax.Add(temp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("error converting to a number from file." + e.Message);
                    break;
                }

            }

            inputFile.Close();
            Console.WriteLine("The array contains " + value.Count + " elements");
            // inputFile.Read();

            foreach (var numbers in value)
            {
                Console.WriteLine("Current value: " + numbers);
            }
            Console.WriteLine(valuesmax.Max());
            Console.WriteLine(FindMin(valuesmax));

            Console.ReadLine();
        }
        public static int FindMin(List<int> input)
        {
            int result = input[0];
            for (int i = 0; i < input.Count; i++)
            {
                result = input[i];
            }
            return result;
        }

       
    }

    
}

