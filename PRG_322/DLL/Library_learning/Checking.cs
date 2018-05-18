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
        
        public Checking(Customer c, double initialAmount):base()
        {
            balance = initialAmount;
            mCustomer = c;
        }
    }
}
