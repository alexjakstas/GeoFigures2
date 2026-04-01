using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class ShapeHelper
    {
        public static double CalculateArea(List<Shape> figures)
        {
            double totalArea = 0;
            foreach (var figure in figures)
            {
                totalArea += figure.GetArea();
                
            }
            return totalArea;
        }

        public static double CalculatePerimeter(List<Shape> figures)
        {
            double totalPerimeter = 0;
            foreach (var figure in figures)
            {
                totalPerimeter += figure.GetPerimeter();
            }
            return totalPerimeter;
        }
    }
}
