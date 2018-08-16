
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesWithUML
{
    public interface IShape
    {

        /// <summary>
        /// @return
        /// </summary>
        double Area();

        /// <summary>
        /// @return
        /// </summary>
        double Perimeter();

        /// <summary>
        /// @return
        /// </summary>
        String Type();

    }
}