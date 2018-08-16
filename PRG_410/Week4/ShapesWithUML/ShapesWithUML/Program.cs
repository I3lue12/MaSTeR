using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesWithUML
{
    class Program
    {
        public static void Main(String[] args)
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Triangle(2.0,4.0);
            shapes[1] = new Rectangle(5.0,4.0);
            shapes[2] = new Circle(3.0);



            for(int i =0; i<shapes.Length; i++)
            {
                Console.WriteLine("Shape type = {0}, Area = {1}, Perimeter = {2} ", shapes[i].Type(), shapes[i].Area(), shapes[i].Perimeter());
            }
            Console.Read();
        }
        
    }
}
