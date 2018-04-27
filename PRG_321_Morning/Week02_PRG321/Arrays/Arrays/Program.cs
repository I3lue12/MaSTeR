using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Arrays
{
    class Program
    {
       


        static void Main(string[] args)
        {
            int[] values = new int[] { 1, 2, 3, 4, 5 };//pre made array, pre alocated space.
            int[] values2 = new int[5];//set number values
            
            ArrayList value3 = new ArrayList();//find out how many
            
            value3.Add(1);
            value3.Add("happy");



            Console.WriteLine("Enter in data or strings to list");

            //value3.Add(Console.ReadLine());

                value3.Add(userInput(Console.ReadLine()));
                
                Console.WriteLine();
                
              
          
            Console.WriteLine("What this does is take in user input and send that info back to you.");


        



            Console.Read();
        }

        public static string userInput(string enteredInfo)
        {
            string sendback = enteredInfo;
           

            return sendback;

        }

    }
}
