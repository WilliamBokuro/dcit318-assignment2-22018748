using System;
    // Abstract Base Class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived Class: Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived Class: Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class AbstractClassDemo
    {
        public static void Run()
        {
            Console.WriteLine("--- Task 2: Abstract Classes & Methods ---");

            Circle myCircle = new Circle(5.0);
            Rectangle myRectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle Area (Radius 5): {myCircle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area (4x6): {myRectangle.GetArea():F2}");

            Console.WriteLine();
        }
    }
