using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_321_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsTeamInfo callingSports = new SportsTeamInfo();

            string sportsCall;
            sportsCall = callingSports.DisplaySport();
            Console.WriteLine(sportsCall);
            Console.ReadKey();
        }
    }
}
