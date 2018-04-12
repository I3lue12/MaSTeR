using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Week02
{
    public class PlaceHolderArrayChp12Assignment:Form
    {
        public static void ArrayExample()
        {
            //int[] a1 = new int[5];
            int[] array1,array2;
            array1 = new int[5] {1,2,3,4,5 };
            array2 = new int[5] {1,2,3,4,5 };

            ArrayList res = new ArrayList();
            for(int i = 0; i<array1.Length; i++)
             res.Add(array1[1] * array2[i]);

            //only works if there is only one code to execute.
            for (int i = 0; i < res.Count; i++)
                Console.WriteLine("res[" + i + "] " + res[i]);
            


        }
    }
}
