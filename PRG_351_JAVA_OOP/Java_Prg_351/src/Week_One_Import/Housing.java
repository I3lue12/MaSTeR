/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_One_Import;

/**
 *
 * @author BLUE
 */
public class Housing implements IUnits
    {
        protected int YearBuilt;
        protected String Address;
        public Paint type;

        //this is my constructor
        public Housing()
        {
            YearBuilt = 1990;
            Address = "Count Cir. ";
            type = new Paint();
             // initializeType();
        }
        
        public Housing(int yearBuilt, String localAddress)//second constructor passing in variables.
        {
            YearBuilt = yearBuilt;
            Address = localAddress;
        }
        void initializeType()
        {
            type = new Paint();
        }
        
        
        
        
        //@Override
        
        //there is no virtual key word in java
        @Override
        public int NumberUnits()
        {
            return 4;
        }
        public double GetRentAmount()
        {
            return 800.50;
        }
        //@Override//to string is never defined adn it doesnt make sence in java
        public String ToString()
        {
            String s = "Year Built: " + YearBuilt + "\nAddress: " + Address;
            return s;
        }
      
    }
