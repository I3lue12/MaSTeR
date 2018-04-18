using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Week02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Coach coach1 = new Coach();
            Coach coach2 = new Coach(coach1);

            coach2 = coach1;
            #region

            //SportTeam t1 = new SportTeam();
            //SportTeam t2 = new SportTeam();
            //t2 = t1;
            //SportTeam_Football tf1 = new SportTeam_Football();
            //SportTeam_Football tf2 = new SportTeam_Football();
            //tf2 = tf1;

            //SportTeam_Tennis tt = new SportTeam_Tennis();
            //SportTeam_Tennis tt2 = new SportTeam_Tennis();
            //tt2 = tt;
            #endregion

            //everything about arrays will be dropped in method
            PlaceHolderArrayChp12Assignment.ArrayExample();

            placeHoldOverrideVurtualNotesAndPractise.UnitTest();//also included the assesment best I could.

            //Assessment 2
            Housing house = new Housing();
            MultiUnit multiroom = new MultiUnit();
            SingleFam singleRoom = new SingleFam();
            singleRoom.Square_Footage = 1500;
            singleRoom.has_Garage = true;
            Console.WriteLine("\nThis is for the assessment 2.\nSingle room: " + singleRoom);

            
            //gui thing
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Week02());

            
           
            Console.ReadLine();
        }
    }
}
