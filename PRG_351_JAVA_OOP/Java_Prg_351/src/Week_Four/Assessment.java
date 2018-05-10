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
    
    public ArrayList<Integer> storeNum = new ArrayList<>();
    public Assessment(){
       
    }
    private int EvenNumLoop()//The sum of all even numbers between 2 and 100 (inclusive).
    {   
        
        int startNum = 0;
        int SumStartNum = 0;
        
        for(int i = 0; i< 101; i++)//could replace startnum with i
        {
            startNum = startNum + 1;
            if(startNum%2==0)
            {
                //even                  //SumStartNum + SumStartNum
                SumStartNum += startNum;//might be startNum + startNum;
            }
            else{
                //odd
            }       
        }
        return SumStartNum;//return the Sum of the loop
    }
    private int SumOfSquare()//The sum of all squares between 1 and 100 (inclusive).
    {
        
        int sumOfSquare = 0;
        for(int i = 1; i < 101 ; i++)
        {
            int checkZero = i*i;
            if(checkZero%2 == 0)
            {
                sumOfSquare += sumOfSquare;//calculate and store sum 1-100
            }       
        }
        return sumOfSquare;//returns sum of square
    }
    
    private ArrayList<Integer> PowerOfTwo()//All powers of 2 from 20 up to 220.
    {
        
        int resultOfTwo = 2;
        
        for(int i = 0; i < 10; i++)
        {           
            Math.pow(resultOfTwo, i);
            
         if(resultOfTwo >= 20 && resultOfTwo<=220)
         {
             storeNum.add(resultOfTwo);//only retrieve numbers that are within range of 20 - 220
         }
        }
        return storeNum;//this will return the max number.
    }
    
    
    private int UserEnterSum(int a, int b)//d. The sum of all odd numbers between a and b (inclusive), where a and b are inputs.
    {
        int totalSum = 0;
        storeNum.clear();
        if(a < b)
        {
                                    // I have the input need to count up to input b.
            while(a <= b)
            {
                                    //store into storeNum
                storeNum.add(a);
                totalSum = totalSum + a;
                a++;                //count up to b
            }
        }
        else
        {
                                    //a is greater then b    
            
            while(a >= b) 
            {                       //store user input a
                storeNum.add(a);
                totalSum = totalSum - a;
                a--;                //need to count down to b.
            }
        }
        
        
        return totalSum;
    }
    
    private ArrayList<Integer> OddExtractInput(int a)
    { 
        int totalSum = 0;
        String numSep = String.valueOf(a);
        storeNum.clear();
        //need to seperate the integer into pieces
        for(int i = 0; i<numSep.length(); i++)
        {
             totalSum = Character.digit(numSep.charAt(i), 10);
             storeNum.add(totalSum);
        }        
        return storeNum;//returns lasat value.
    }
    
    public void Print(){
        Scanner scnr = new Scanner(System.in);
        String outPut;
        
        System.out.println(numLoop());
        System.out.println(SumOfSquare());
        //return outPut;
    }
    
    public static void UnitTest()
    {
        Assessment.UnitTest();
        
       
        
        
        
        
    }
    
}
