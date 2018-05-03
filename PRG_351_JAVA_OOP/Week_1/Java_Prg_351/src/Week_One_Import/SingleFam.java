/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_One_Import;

import Week_One_Import.Housing;

/**
 *
 * @author BLUE
 */
public class SingleFam extends Housing implements IUnits
    {
        private double SquareFootage;
        private boolean hasGarage;
        
        //setget for SquareFootage
        //accesses the function not the variable.
        //because you created a single family class you set it for that class
        //and when you get you get it for that class.
        
        
        //        Import From CSharp
//        public double Square_Footage //property
//        {
//            set { SquareFootage = value; }
//            get { return SquareFootage; }
//        }
//       
        public void SetSqaureFootage( double iSquareFootage)
        {
            SquareFootage = iSquareFootage;
        }
        //dont need to pass through anything because we have access to Sqaure footage.
        public double GetSquareFootage()
        {          
            return SquareFootage;
        }
        
        
               //Import From csharp
//        public bool has_Garage
//        {
//            set { hasGarage = value; }
//            get { return hasGarage; }
//        }
        
        
        public void SetHasGarage(boolean f)
        {
            hasGarage = f;
        }
        public boolean GetHasGarage()
        {
            return hasGarage;
        }
 
     
        @Override
        public String ToString()
        {
            //String fromHousingInfo = base.ToString();
            String newInformation = "\nSquare Feet = " + SquareFootage + "\nUnit has a Garage: ";
            if(hasGarage == true)
            {
                newInformation += "Has Garage.";
            }
            else
            {
                newInformation += "No Garage.";
            }
           // return fromHousingInfo + newInformation;
            return newInformation;
        }
    }
