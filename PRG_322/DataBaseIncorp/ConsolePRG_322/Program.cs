using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseIncorp;

namespace ConsolePRG_322
{
    class Program
    {
        static void Main(string[] args)
        {
            AgnosticDatabaseManager msg = new AgnosticDatabaseManager();
            List<StudentInfo> lst = msg.ExtractData();

            for(int i = 0; i < lst.Count; i++)
            {
                string s = "ID = " + lst[i].ID + " ";
                s += "- First Name: " + lst[i].FirstName + " ";
                s += "- Last Name: " + lst[i].LastName + " ";
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }
    }
}
