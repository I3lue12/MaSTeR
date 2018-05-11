/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_Four;

import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;
/**
 *
 * @author BLUE
 */
public class Assessment {
    
    /*
a. The sum of all even numbers between 2 and 100 (inclusive).

b. The sum of all squares between 1 and 100 (inclusive).

c. All powers of 2 from 20 up to 220.

d. The sum of all odd numbers between a and b (inclusive), where a and b are inputs.

e. The sum of all odd digits of an input. (For example, if the input is 32677, the sum would be 3+7+7=17.)
   
    */
    
    public static ArrayList<Integer> storeNum = new ArrayList<>();
    public Assessment(){   
    }
    private static int EvenNumLoop()//The sum of all even numbers between 2 and 100 (inclusive).
    {       
        int startNum = 0;
        int SumStartNum = 0;
        
        for(int i = 0; i< 101; i++)//could replace startnum with i
        {

            if(i%2==0)
            {
                //even                  //SumStartNum + SumStartNum
                SumStartNum += i;//might be startNum + startNum;
            }
            else{
                //odd
            }       
        }
        return SumStartNum;//return the Sum of the loop
    }
    private static int SumOfSquare()//The sum of all squares between 1 and 100 (inclusive).
    {
        
        int sumOfSquare = 0;
        for(int i = 1; i < 101 ; i++)
            sumOfSquare += i*i;//calculate and store sum 1-100  
        
        return sumOfSquare;//returns sum of square
    }
    private static ArrayList<Integer> PowerOfTwo()//All powers of 2 from 20 up to 220.
    {
        for(int i = 20; i < 221; i++)       
             storeNum.add(i * i );//only retrieve numbers that are within range of 20 - 220
        return storeNum;//this will return the max number.
    }
    
    private static int UserEnterSum(int a, int b)//d. The sum of all odd numbers between a and b (inclusive), where a and b are inputs.
    {
        int totalSum = 0;
        storeNum.clear();
        
        int lowerBound = 0;
        int upperBound = 0;
        if( a < b ) {
            lowerBound = a;
            upperBound = b;
        } else {
            lowerBound = b;
            upperBound = a;
        }
        if(lowerBound < upperBound)
        {
                                    // I have the input need to count up to input b.
            while(lowerBound <= upperBound)
            {
                 if(lowerBound%2!=0)//check odd numbers
                 {
                    storeNum.add(lowerBound);//store into storeNum to check the numbers if desired;
                    totalSum = totalSum + lowerBound;//Store and add sum
                    
                 }
                
                              
                 lowerBound++;  //count up to b
            }
        }
//        else if (a>b)
//        {
//                                    //a is greater then b    
//            
//            while(a >= b) 
//            {                       //store user input a
//                if(a%2!=0)
//                {
//                    storeNum.add(a);
//                    totalSum = totalSum + a;
//                                   
//                }
//                a--; //need to count down to b.
//            }
//            
//        }
        if( lowerBound == upperBound ) 
        {
            //a and b are the same input
            totalSum = a+b;
        }
        
        
        return totalSum;
    }
    
    private static int OddExtractInput(int a)//e. The sum of all odd digits of an input.
    {           
//        ArrayList<String> seperatedInputString = new ArrayList<>();
//        ArrayList<Integer> seperatedInputNum = new ArrayList<>();
        
        int totalSum = 0;
        String numStep = String.valueOf(a);
        
        //need to seperate the integer into pieces
        for(int i = 0; i<numStep.length(); i++)//goes through the length of the input number
        {
            int val1 = (int)(numStep.charAt(i)) - 48;//we use ascii 
            if( val1 % 2 != 0 )
                totalSum += val1;
            //numStep.charAt(i)
           //     seperatedInputString.add(i,numStep);//place  individual numSep into its own []
            //now convert list into ints.           
        }
//        
//        int tempNum = 0;
//        for(int j = 0; j < seperatedInputString.lastIndexOf(numStep); j++)
//        {
//            
//            
//            if(Character.digit(numStep.charAt(j), 10)%2 != 0)//get base 10 of that character from the string
//            {
//                  tempNum = tempNum + Character.digit(numStep.charAt(j), 10);//add the odds
//            }
//                 
//        }
        
      
        //add all numbers in store num;
       // totalSum = ;     
        
        return totalSum;//returns last value.
        
    }                                       //(For example, if the input is 32677, the sum would be 3+7+7=17.)
    
    private static void Print()
    {
        Scanner scnr = new Scanner(System.in);
        String outPut;
        
        System.out.println(EvenNumLoop());
        System.out.println(SumOfSquare());
        System.out.println(PowerOfTwo());
        System.out.println(UserEnterSum(25,34));
        System.out.println(OddExtractInput(12345));
        
        //return outPut;
    }
    
    public static void UnitTest()
    {
        
        Print();     
        
    }
    
}
