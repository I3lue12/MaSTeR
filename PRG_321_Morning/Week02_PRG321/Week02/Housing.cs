using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
   
    public class Housing : Interface1
    {
        protected int YearBuilt;
        protected string Address;

        public virtual int NumberUnits()
        {
            return 4;
        }
        public virtual double GetRentAmount()
        {
            return 800.50;
        }
        public override string ToString()
        {
            string s = "Year Built: " + YearBuilt + "\nAddress: " + Address;
            return s;
        }
        public Housing()
        {
            YearBuilt = 1990;
            Address = "Count Cir. ";
        }
    }
    

}
