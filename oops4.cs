using project;
using System;
namespace project
{
    public abstract class absParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    public class Child : absParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
namespace project1
{
    class program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Add(10, 23);
            c.Div(10, 2);
            c.Mul(23, 3);
            c.Sub(21, 2);
        }
    }
}