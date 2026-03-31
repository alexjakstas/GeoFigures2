using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GeoFigures
{
    internal class Rectangle
    {
        private double _width;
        private double _height;
        public double Width { get { return _width; } 
            set 
            {
               
                if (value < 0)
                {
                    
                    Console.WriteLine("number must be greater then 0");
                    return;
                    
                }
                _width = value;
            } 
        }
        public double Height { get { return _height; }
            set
            {
                
                if (value < 0)
                {
                    
                    Console.WriteLine("number must be greater then 0");
                    return;
                    
                }
                _height = value;
            } 
        }

        public static double GetArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }

        public static double GetPerimeter(Rectangle rectangle)
        {
            return (rectangle.Width + rectangle.Height) * 2;
        }
    
        public  Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }
    }
}
