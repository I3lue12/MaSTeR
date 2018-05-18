using System;
using System.Collections.Generic;
using System.Text;

namespace Library_learning
{
    public class Saving:Account//only works with override do stuff.
    {
        //implement DoStuff() due to the abstract method.
        public override void DoStuff()
        {
            
        }
        //make sure the class' constructor is calling the parent class constructor(AKA base()).
       
        public Saving(Customer c,double initialAmount):base()
        {
            balance = initialAmount;
            mCustomer = c;
        }
    }
}
