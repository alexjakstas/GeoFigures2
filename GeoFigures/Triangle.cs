using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public static double GetArea(Triangle triangle)
        {
            return triangle.Base * triangle.Height / 2;
        }

        public static double GetPerimeter(Triangle triangle)
        {
            return triangle.Base * 3;
        }

        public Triangle(double triabeBase, double triangleHeight)
        {
            Base = triabeBase;
            Height = triangleHeight;
        }
    }
}
