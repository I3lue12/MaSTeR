/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_One.Assignment;

/**
 *
 * @author BLUE
 */
public class BankAccount {
    //balance
    //interest rate
    double balance;
    double interestRate;
    
    public BankAccount(double inputBalance, double inputInterestRate)
    {
        balance = inputBalance;
        interestRate = inputInterestRate;
    }
    
    public double addInterest(double interest)//E3.4
    {
        balance = balance * (1.0 + interest/100);
        return balance;
    }
    
    public double Deposit(double ammount)//E3.4
    {
        balance += ammount;
        return balance;
    }
    public double Withdraw(double ammount)//E3.4
    {
        balance -= ammount;
        return balance;
    }
    public double AddTwoInputs(double a, double b)
    {
        return 0.0;//work on later
    }
    
    public BankAccount(double inputBalance)//E3.4
    {
        balance = inputBalance;
        interestRate = 0.0;
    }
    
    public String ToString()
    {
        String s = "Balance = " + balance + ", Interest Rate = " + interestRate;
        return s;
    }
    
    public double ComputeBalanceJordan(int numberYears)
    {
        double ammount = balance;
        double rate = interestRate;
        //this works
        for(int i = 0; i < numberYears; i++)
        {
            ammount = ammount * (1.0 + rate);
        }
        return ammount;
    }
    public double ComputeBalanceAfter(int numberYears)
    {
        double ammount = balance;
        double rate = interestRate;
        
        double yearPlusNext;
   
        return ammount * Math.pow((1+rate), numberYears);
       
    }
    
   
    public static void UnitTest()
    {
        BankAccount ba = new BankAccount(500, 0.05);//takes peramiters
        ba.ToString();
        
        System.out.println(ba.ToString());
        //the for loop
        System.out.println(ba.ComputeBalanceJordan(4));
        //the formula way
        System.out.println(ba.ComputeBalanceAfter(4));
        
    }
}
