using System;
using System.Collections.Generic;
using System.Text;

namespace Library_learning
{
    public class Checking : Account
    {
        

        public override void DoStuff()//abstract inheritance requirments.
        {
            
        }
        public Checking() : base()
        {
           // mCustomer = new Customer();
        }
        public Checking(double initialAmount):base()
        {
            balance = initialAmount;
        }
    }
}
