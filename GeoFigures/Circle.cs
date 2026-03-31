using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Circle
    {
        public double Radius { get; set; }

    

        public static double GetArea(Circle c)
        {
            return Math.PI * c.Radius * c.Radius;
        }
  
        public static double GetPerimeter(Circle c)
        {
            return 2 * c.Radius * Math.PI;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
