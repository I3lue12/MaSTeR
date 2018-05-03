/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week_One_Import;

import Week_One_Import.Housing;

/**
 *
 * @author BLUE
 */

                                        //extends is : in c#
                                        // impliments is , in c#
public class MultiUnit extends Housing implements IUnits
    {
        @Override//override in java is different then java
        public int NumberUnits()
        {
            return 20;
        }
    }
