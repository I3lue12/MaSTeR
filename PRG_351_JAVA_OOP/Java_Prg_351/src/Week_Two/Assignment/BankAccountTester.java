/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_Two.Assignment;
import Week_One.Assignment.BankAccount;
/**
 *
 * @author BLUE
 */
//E3.3
public class BankAccountTester {
    
    public static void main(String[] args) {
        
    BankAccount momsSavings = new BankAccount(1000.0);
    momsSavings.Withdraw(500);
    double renamingBalance = momsSavings.Withdraw(400);
    System.out.println("Moms balance: $" + renamingBalance);
    
    
    System.out.println("if Mom has 1000 savings");
    
    double newBalance = momsSavings.addInterest(10);
    System.out.println("new balance with 10 percent interest:  "+ newBalance);
    
    double firstNum,secondNum;
    
    
    
    
    }
    
}
