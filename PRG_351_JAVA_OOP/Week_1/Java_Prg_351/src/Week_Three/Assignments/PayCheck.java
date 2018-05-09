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
        boolean overTime = (hours.value > 40.0);
        
        if(overTime == true)
        {
            double salary = (((hours.value - 40)*(hourlyRate.value * 1.5)) );
            salary += 40.0 *hourlyRate.value;
            return salary;
        }
        else
        {
            double salary = hours.value * hourlyRate.value;
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
        hourlyRate = new HourleyRate();//need to initualize refrenses
        hours = new NumberHours();
        
        hourlyRate.value = ihourlyRate.value;
        hours.value = inumHours.value;
    }
   
    
    
    public static void Unit_Test(){
        
        Scanner scnr = new Scanner(System.in);
         
         NumberHours iHoursWorked = new NumberHours();
         iHoursWorked.value = 12.5;
         
         
         HourleyRate iHourlyRate = new HourleyRate();
         iHourlyRate.value = 25.5;
       
         //this way we cant get the variables mixed up.
        PayCheck pCheck = new PayCheck(iHourlyRate,iHoursWorked);
        
        double salary = pCheck.ComputeSalary();
        System.out.println("Your salary is: " + salary);
        
        
        //PayCheck pCheck = new PayCheck(iHoursWorked,iHourlyRate);//cannot do this, we prevent this from happeneing 
                                                                   //we pass through hourleyRate,NumberHours refrences
                                                                   
        System.out.println("What is your Hourly Rate:");
        iHourlyRate.value = scnr.nextDouble();
                                                
        System.out.println("What is your Hourly worked:");
        iHoursWorked.value = scnr.nextDouble();
       
        PayCheck pCheck2 = new PayCheck(iHourlyRate,iHoursWorked);                                                 
        double salary2 = pCheck.ComputeSalary();
        System.out.println("Your salary is: " + salary2);
    }
}
