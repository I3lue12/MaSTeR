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
public class NumberHours {
    
    private double value;
    private void NumberHours(){
        
    }
    public NumberHours(double v){
        value = 0;
        if(v >= 0)
        {
           value = v; 
        }        
    }
    public void setNumHours(double nHours){
        value = nHours;
        
    }
    /*
    @brief Retrieves the number of hours
    @func NumberHours
    @param v the value to set the number of hours to.    
    */
    public double getHours(){
        return value;
    }
    
     
}
