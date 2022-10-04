using project;
using System;
namespace project
{
    interface Icalculator
    {
        void Add();
    }
    interface Icalculator1
    {
        void Sub();
    }
    interface Icalculator2
    {
        void Mul();
    }
    public class Calculator : Icalculator, Icalculator1, Icalculator2
    {
        private int a;
        private int b;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public void Add()
        {
            Console.WriteLine(a + b);
        }
        public void Sub()
        {
            Console.WriteLine(a - b);
        }
        public void Mul()
        {
            Console.WriteLine(a * b);
        }
    }
}
namespace project1
{
    class program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.A = 10;
            c.B = 20;
            c.Add();
            c.Sub();
            c.Mul();
        }
    }
}