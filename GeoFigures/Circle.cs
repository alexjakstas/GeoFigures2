using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

    

        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
  
        public override double GetPerimeter()
        {
            return 2 * this.Radius * Math.PI;
        }

        public Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
