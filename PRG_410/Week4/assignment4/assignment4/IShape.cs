
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IShape {

    /// <summary>
    /// @return
    /// </summary>
    public abstract double Area();

    /// <summary>
    /// @return
    /// </summary>
    public abstract double Perimeter();

    /// <summary>
    /// @return
    /// </summary>
    public abstract String Type();

}