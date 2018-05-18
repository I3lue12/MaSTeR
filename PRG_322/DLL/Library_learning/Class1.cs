using System;
 
namespace Library_learning
{
    public class DLL
    {
        public static void DllRun()
        {  

            FirstName f = new FirstName("brendon");
            LastName l = new LastName("yep");
            SSN s = new SSN("thats a number");
            Customer c = new Customer(f, l, s);

            Checking ca = new Checking(c, 5000);
            Saving sv = new Saving(c, 2000);

            Customer copy = c;//backup




            //Console.WriteLine("I am a dll, to the tune of iron man");
            //Console.WriteLine("this works only after building.");
            //Console.WriteLine("solution.");
            //Checking ba = new Checking(c, 500);



            //Saving sv = new Saving(300);


            Console.WriteLine(sv.ReturnBalance()+ " " + ca.ReturnBalance());
        }
    }
}
