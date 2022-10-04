using project;
using System;
namespace project
{
    public abstract class shape
    {
        public double Height;
        public double Width;
        public double Radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : shape
    {
        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    }
    public class Circle : shape
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return pi * Radius * Radius;
        }
    }
    public class Triangle : shape
    {
        public Triangle(double Height, double Width)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return (Height * Width) / 2;
        }
    }
}
namespace project1
{
    class program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Triangle t = new Triangle(12, 2);
            Circle c = new Circle(8);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(t.GetArea());
            Console.WriteLine(c.GetArea());

        }
    }
}