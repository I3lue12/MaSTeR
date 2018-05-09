/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_Three.Assignments;
import java.util.*;
/**
 *
 * @author BLUE
 */
public class Intro_Chp_5 {
    
     
    public static void UnitTest()
    {      
        int a = 1;
        int b = 1;
        if(a == 1)
        {
            System.out.println("Hello! WORLD!"); 
        }
        else
        {
            System.out.println("somehow a didnt equal 1");
        }
       
        if(b==0)
            System.out.println("no braces!");
        else
        {
            System.out.println("b is 1: no braces. " + b);
            b = b+1;
        }
        //region
        a=0;
        b=0;
        
        int c = (a<0)?1:5;//same as below
        if(a<0)
            b=1;
        else
            b=5;
        
        
        //endregion
        int j=1;
        for(int i = 0; i < 2; i++)
        {        
            System.out.println("I am in a loop, this is pass: " + j);
            j++;
        }
              
        
        
        /*
        == - comparison
        != - inequal
        >= - greater or equal to
        <= - lesser or equal too
        && - AND
        || - OR
        */
        
        char letter = 'n';
        
        Scanner scnr = new Scanner(System.in);
        while(letter != 'y')
        {
            System.out.println("Enter response: y/n");            
//            String myString = scnr.next();//long version of 
//            letter = myString.charAt(0);//long version of bellow.          
            letter = scnr.next().charAt(0);//method chaining. method().method()
            
        }
        
        
        
        
    }
    
}
