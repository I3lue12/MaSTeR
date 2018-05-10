/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_Three.Assignments;
import java.util.Scanner;
/**
 *
 * @author BLUE
 */
public class PayCheck {
    
    private HourleyRate hourlyRate;// variable hourlyRate is refrenced to type HourleyRate
    private NumberHours hours;//noone needs a access
    
    
    
    
    double ComputeSalary()
    {
        boolean overTime = (hours.getHours() > 40.0);
        
        if(overTime == true)
        {
            double salary = (((hours.getHours() - 40)*(hourlyRate.getRate() * 1.5)) );
            salary += 40.0 *hourlyRate.getRate();
            return salary;
        }
        else
        {
            double salary = hours.getHours() * hourlyRate.getRate();
            return salary;
        }     
    }
    
    //this will prevent default paychecks from being instaniated.
    private void PayCheck()
    {
        int cantFindThisHaHa = 1;
    }
    public PayCheck(HourleyRate hlyRate, NumberHours numHours)
    {
        hourlyRate = hlyRate;
        hours = numHours;
        
    }
    
    public void Paycheck(HourleyRate ihourlyRate, NumberHours inumHours)//this makes it so when passed through
                                                                       //so we cant have the types confused
    {
        hourlyRate = new HourleyRate(ihourlyRate.getRate());//need to initualize refrenses
        hours = new NumberHours(inumHours.getHours());//passed in 
        
        //commented out because we made the classes private and value iis unaccessible.
//        hourlyRate.value; = ihourlyRate.value;
//        hours.value = inumHours.value;
    }
   
    public void setHourlyRate(double value)
    {
        this.hourlyRate.HourleyRate(value);
    }
    
    public static double MarshallUserInput(String prompt1, String promt2)
    {
        
        
        double returnValue = 0;
        boolean valueCorrectEntered = false;
        double hourRate = 0.0;
        while(valueCorrectEntered == false)
        {
            
            System.out.println(prompt1);
            try{
                Scanner scnr = new Scanner(System.in);
                double val = scnr.nextDouble();
                if(val < 0)
                {
                    System.out.println(promt2);
                }
                else{
                    returnValue = val;
                    valueCorrectEntered = true;
                }
                
            }
            catch(Exception e){
                String error_message = e.getMessage();
                System.out.println("error catch in Enter hourly rate" + e.getMessage());
            }
        }
        
        return returnValue;
    }
    
    
    public static void Unit_Test(){
        
        Scanner scnr = new Scanner(System.in);
         
         
         
//         NumberHours iHoursWorked = new NumberHours();
//         iHoursWorked.value = 12.5;
//         
//         
//         HourleyRate iHourlyRate = new HourleyRate();
//         iHourlyRate.value = 25.5;
//       
//         //this way we cant get the variables mixed up.
//        PayCheck pCheck = new PayCheck(iHourlyRate,iHoursWorked);
//        
//        double salary = pCheck.ComputeSalary();
//        System.out.println("Your salary is: " + salary);
               
        //PayCheck pCheck = new PayCheck(iHoursWorked,iHourlyRate);//cannot do this, we prevent this from happeneing 
                                                                   //we pass through hourleyRate,NumberHours refrences      
//        System.out.println("What is your Hourly Rate:");
//        iHourlyRate.value = scnr.nextDouble();
//                                                
//        System.out.println("What is your Hourly worked:");
//        iHoursWorked.value = scnr.nextDouble();
//       
//        PayCheck pCheck2 = new PayCheck(iHourlyRate,iHoursWorked);                                                 
//        double salary2 = pCheck.ComputeSalary();
//        System.out.println("Your salary is: " + salary2);
        
        
        //improved week 3 Assignment 5/9/2018
        
         String prompt1 = "Enter an hourly rate:\r\n ";
         String prompt2 = "You need to enter a positive number for hour Rate.\r\n";
        
         String prompt3 = "Enter a number of hours.\r\n";
         String prompt4 = "You need to enter a possitive number for hour worked.\r\n";
        
         double hourly_rate = MarshallUserInput(prompt1,prompt2);
         double num_hours = MarshallUserInput(prompt3,prompt4);
         
         // 5/10/2018
         
//        double hourly_rate = 12; 
//        double  num_hours = 12;
         
         HourleyRate iHourlyRate = new HourleyRate(hourly_rate);
         NumberHours inumHours = new NumberHours(num_hours);
         
         
        
         PayCheck p = new PayCheck(iHourlyRate, inumHours);
         double salary = p.ComputeSalary();
         System.out.println("Your salary is: " + salary);
         
    }
}
