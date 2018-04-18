using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    public class Parent
    {
        virtual public void SayHello()
        {
            Console.WriteLine("Parent");
        }
    }
    public class Child:Parent
    {
        public override void SayHello()
        {
            Console.WriteLine("I am the Child");
            
        }
    }
    public class Housingexperiment
    {
        public string address, yearBuilt;
        public virtual string YearBuilt()
        {
            return yearBuilt = "1988";
        }
        public virtual string Address()
        {
           return address = "He lives in this cubical";
        }
        public virtual double TotalRentalAmount(double deposit, double ratePerMonth, double numberOfUnits)
        {
             double totAmount = deposit + ratePerMonth * numberOfUnits;
             return totAmount;
        }
        
    }
    public class HousingUnits:Housingexperiment
    {
        public override double TotalRentalAmount(double totalDeposit, double ratePerMonth, double numberOfUnits)
        {
            double totAmount = totalDeposit + ratePerMonth * numberOfUnits;
            return totAmount;
        }
    }
  
    public class placeHoldOverrideVurtualNotesAndPractise
    {
        public static void UnitTest()
        {
            //Parent p = new Parent();
            //Child c = new Child();
            //p.SayHello();
            //c.SayHello();

            Housingexperiment cost = new Housingexperiment();
            
            Console.WriteLine("This is how much per unit: $"+cost.TotalRentalAmount(20,100,1));
            HousingUnits totCost = new HousingUnits();
            Console.WriteLine("This is how much total for all units: $"+totCost.TotalRentalAmount(20.00,100.00, 25));

            return;
        }
    }
}
