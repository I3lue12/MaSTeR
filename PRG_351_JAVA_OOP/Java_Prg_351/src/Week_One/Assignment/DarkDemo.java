/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_One.Assignment;
import javax.swing.JFrame;
/**
 *
 * @author BLUE
 */
public class DarkDemo {
    
    public static void Unit_Test()
    {
        JFrame f2 = new JFrame();
        f2.setSize(400,400);
        java.awt.Color c4 = java.awt.Color.RED;
        
        java.awt.Color c5 = c4.darker();
        java.awt.Color c6 = c5.darker();
        f2.getContentPane().setBackground(c6);
        f2.show();
        
    }
}
