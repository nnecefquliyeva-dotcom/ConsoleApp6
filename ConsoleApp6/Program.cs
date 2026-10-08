using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }
    class Circle : IShape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : IShape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Triangle : IShape
    {
        public double A;
        public double B;
        public double C;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double CalculateArea()
        {
            double s = (A + B + C) / 2;

            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
        public double CalculatePerimeter()
        {
            return A + B + C;
        }
    }
    class ShapeHelper
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Circle(4));
            shapes.Add(new Rectangle(3, 5));
            shapes.Add(new Triangle(3, 4, 5));

            foreach (IShape shape in shapes)
            {
                if (shape is Circle)
                {
                    Console.WriteLine("Dairenin sahesi: " + shape.CalculateArea());
                    Console.WriteLine("Dairenin perimetri: " + shape.CalculatePerimeter());
                }
                else if (shape is Rectangle)
                {
                    Console.WriteLine("Duzbucaglinin sahesi: " + shape.CalculateArea());
                    Console.WriteLine("Duzbucaglinin perimetri: " + shape.CalculatePerimeter());
                }
                else if (shape is Triangle)
                {
                    Console.WriteLine("Ucbucagin sahesi: " + shape.CalculateArea());
                    Console.WriteLine("Ucbucagin perimetri: " + shape.CalculatePerimeter());
                }

                Console.WriteLine();
            }

        }
    }
}