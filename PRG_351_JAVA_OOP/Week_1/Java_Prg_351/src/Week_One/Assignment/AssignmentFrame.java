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
//we are makeing a JFrame to make graphics
//we used the color class to get r and b and g  to make colors.
public class AssignmentFrame {
    public static void Unit_Test()
    {
        
        Color c = new Color(50,100,180);//Week_One.Assignment.Color() - we made this
        JFrame f = new JFrame();
        JFrame f2 = new JFrame();
        f2.setSize(400,400);
        f.setSize(400,400);
        //we used our class color from Color we made
        //we then used java.awt.color(,,) but in that we used our own object of type color we made.
        //f.getContentPane().setBackground(new java.awt.Color(c.GetR(),c.GetG(),c.GetB()));//java.aw.Color  java made this
        //f.show();
        
        java.awt.Color c2 = new java.awt.Color(150, 100, 50);
        java.awt.Color c3 = c2.brighter();
        int r = c3.getRGB();
        int g = c3.getGreen();
        int b = c3.getBlue();
        
        System.out.println("this rgb: "+ r);
        f.getContentPane().setBackground(c3);
        f.show();
        
        f2.getContentPane().setBackground(c2);
        f2.show();
        
      
        
    }
}
