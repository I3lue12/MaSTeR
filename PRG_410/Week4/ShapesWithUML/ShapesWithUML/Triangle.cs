
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ShapesWithUML
{
    public class Triangle : IShape
    {

        private Triangle()
        {
        }

        private double mWidth;

        private double mHeight;

        /// <summary>
        /// @return
        /// </summary>
        public double Area()
        {
            // TODO implement here
            return (mWidth * mHeight) / 2;
        }

        /// <summary>
        /// @return
        /// </summary>
        public double Perimeter()
        {
            // TODO implement here
            double diagSq = (mHeight * mHeight) + (mWidth * mWidth);
            double diag = Math.Sqrt(diagSq);

            return (diag + mHeight + mWidth);
        }

        /// <summary>
        /// @param width 
        /// @param height
        /// </summary>
        public Triangle(double width, double height)
        {
            mWidth = width;
            mHeight = height;
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public string Type()
        {
            // TODO implement here
            return "Right Triangle";
        }

    }
}