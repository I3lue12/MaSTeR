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
public class Color 
{
    private int mR;
    private int mG;
    private int mB;
    
    //we use this too get the GetR,GetG, GetB
    public int GetR()
    {
        return mR;
    }
    public int GetG() 
    {
        return mG;
    }
    public int GetB() 
    {
        return mB;
    }
    
    public Color(int r, int g, int b)
    {
        mR = r;
        mG = g;
        mB = b;        
    }
    
    public String ToString()
    {
        String s = "R = " + mR + ", g = "+ mG +", b = " + mB;
        return s;
    }
    public static void UnitTest()
    {
        Color colr = new Color(120,200,500);
        System.out.println(colr.ToString());      
    }
}
