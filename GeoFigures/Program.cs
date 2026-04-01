using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace GeoFigures
{


    internal class Program4
    {
        static void Main(string[] args)
        {
            //            Circle c = new Circle();

            //            Console.WriteLine("Enter Radius: ");
            //            c.Radius = Convert.ToDouble(Console.ReadLine()); ;


            //            double area = Circle.GetArea(c);
            //            double perimeter = Circle.GetPerimeter(c);

            //            Console.WriteLine("Area of circle is: " + area);
            //            Console.WriteLine("Circle perimeter: " + perimeter);

            //            Circle c2 = new Circle(5);

            ////

            //            Triangle triangle = new Triangle();

            //            Console.WriteLine("Enter base of Triangle: ");
            //            triangle.Base = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Enter Tiangle height: ");
            //            triangle.Height = Convert.ToDouble(Console.ReadLine());

            //            double triangleArea = Triangle.GetArea(triangle);
            //            double trianglePerimeter = Triangle.GetPerimeter(triangle);

            //            Console.WriteLine("Area of Triangle: " + triangleArea);
            //            Console.WriteLine("Perimeter of Triangle: " + trianglePerimeter);

            //            Triangle triangle2 = new Triangle(5, 10);
            ////



            //            Rectangle rectangle = new Rectangle();

            //            Console.WriteLine("Enter width of Rectangle: ");
            //            rectangle.Width = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Enter Rectangle height: ");
            //            rectangle.Height = Convert.ToDouble(Console.ReadLine());

            //            double rectangleArea = Rectangle.GetArea(rectangle);
            //            double rectanglePerimeter = Rectangle.GetPerimeter(rectangle);

            //            Console.WriteLine("Area of Rectangle: " + rectangleArea);
            //            Console.WriteLine("Perimeter of Rectangle: " + rectanglePerimeter);

            //            Rectangle rectangle2 = new Rectangle(5, 10);

            List<Shape> figures = new List<Shape>();

            figures.Add(new Circle(5));
            figures.Add(new Triangle(5, 10));
            figures.Add(new Rectangle(5, 10));

            foreach (var figure in figures)
            {
                Console.WriteLine($"Area: {figure.GetArea()}");
                Console.WriteLine($"Perimeter: {figure.GetPerimeter()}");
            }
        }
    }
}

