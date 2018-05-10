/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_Three.Assignments;

/**
 *
 * @author BLUE
 */
public class HourleyRate {
    
    private double value;
    private void HourleyRate(){
    
}
    public HourleyRate(double v){
        value = 0;
        if(v >= 0)
        {
           value = v; 
        }
    }
    public void HourleyRate(double hRate){
        value = hRate;
        
    }
    public double getRate(){
        return value;
    }
}
