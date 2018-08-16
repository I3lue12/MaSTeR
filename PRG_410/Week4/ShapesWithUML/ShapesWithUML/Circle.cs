
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ShapesWithUML
{
    public class Circle : IShape
    {

        

        public double mRadious;


        /// <summary>
        /// @return
        /// </summary>
        public String Type()
        {
            // TODO implement here
            return "Circle";
        }

        /// <summary>
        /// @param Radious
        /// </summary>
        public Circle(double radious)
        {
            // TODO implement here
            mRadious = radious;
        }

        public double Perameter()
        {
            // TODO implement here
            return 2 * Math.PI * mRadious * mRadious;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * mRadious;
        }
        /// <summary>
        /// @return
        /// </summary>
        public double Area()
        {
            // TODO implement here
            return Math.PI*mRadious*mRadious;
        }

       
       
    }
}