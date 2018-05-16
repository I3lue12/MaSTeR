using System;

namespace Library_learning
{
    public class DLL
    {
        public static void DllRun()
        {
            Console.WriteLine("I am a dll, to the tune of iron man");
            Console.WriteLine("this works only after building.");
            Console.WriteLine("solution.");
            Checking ca = new Checking(500);
            Saving sv = new Saving(300);


            Console.WriteLine(" " + ca.ReturnBalance());
        }
    }
}
