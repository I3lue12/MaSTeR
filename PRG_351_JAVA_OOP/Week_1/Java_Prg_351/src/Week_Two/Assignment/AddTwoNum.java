/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_Two.Assignment;
import java.util.Scanner;
/**
 *
 * @author BLUE
 */
//E4.4
public class AddTwoNum {
    
    
    
    public static void Unit_Test(){
        
        int[] arrayInt = new int[2];
        System.out.println("Enter in a number: ");
        Scanner sc = new Scanner(System.in);
        
        
        arrayInt[0] = sc.nextInt();
        arrayInt[1] = sc.nextInt();
        
        int sum = arrayInt[0]+arrayInt[1];
        int diff = arrayInt[0]-arrayInt[1];
        int product = arrayInt[0]*arrayInt[1];
        double avrg = (double)sum / arrayInt.length;
        int dist = Math.abs(diff);
        int max = Math.max(arrayInt[0], arrayInt[1]);
        int min = Math.min(arrayInt[0], arrayInt[1]);
        
        
        System.out.format("Sum =       %+04d%n", sum);
        System.out.println("Sum =        " + sum);
        System.out.println("Differnece = " + diff);
        System.out.println("Product =    " + product);
        System.out.println("Average =    " + avrg);
        System.out.println("Distance =   " + dist);
        System.out.println("Maximum =    " + max);
        System.out.println("Minimum =    " + min);
    }
}
