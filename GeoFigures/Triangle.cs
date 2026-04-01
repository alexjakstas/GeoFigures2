using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return this.Base * this.Height / 2;
        }

        public override double GetPerimeter()
        {
            return this.Base * 3;
        }
        public Triangle()
        {
        }

        public Triangle(double triabeBase, double triangleHeight)
        {
            Base = triabeBase;
            Height = triangleHeight;
        }
    }
}
