
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesWithUML
{
    public class Rectangle : IShape
    {


        Width cWidth;
        private double mWidth;

        private double mHeight;

        private Rectangle()
        {

            // TODO implement here
        }

        /// <summary>
        /// @param width 
        /// @param height
        /// </summary>
        
            
        //public Rectangle(Width w)
        //{
          
        //   // cWidth = w;
          
        //    // TODO implement here
        //}

        public Rectangle(double w, double h)
        {
            mWidth = w;
            mHeight = h;
            // todo implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public double Area()
        {
            // TODO implement here
            return mWidth * mHeight;
        }

        /// <summary>
        /// @return
        /// </summary>
        public double Perimeter()
        {
            // TODO implement here
            return 2 * (mHeight + mWidth);
        }

        /// <summary>
        /// @return
        /// </summary>
        public String Type()
        {
            // TODO implement here
            return "Rectangle";
        }

    }
}