using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class SingleFam : Housing,Interface1
    {
        private double SquareFootage;
        private bool hasGarage;
        public double Square_Footage
        {
            set { SquareFootage = value; }
            get { return SquareFootage; }
        }
        public bool has_Garage
        {
            set { hasGarage = value; }
            get { return hasGarage; }
        }
        public override string ToString()
        {
            string fromHousingInfo = base.ToString();
            string newInformation = "\nSquare Feet = " + SquareFootage + "\nUnit has a Garage: ";
            if(has_Garage == true)
            {
                newInformation += "Has Garage.";
            }
            else
            {
                newInformation += "No Garage.";
            }
            return fromHousingInfo + newInformation;
        }
    }
}
