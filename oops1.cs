using project;
using System;
namespace project
{
    class employee
    {
        public int id;
        public string name;
        private static string organisationname;
        public employee() : this("tarun", 30)// calling an overloaded constructor in default constructor
        {
            Console.WriteLine("constructor is called");
        }
        static employee()
        {
            organisationname = "monack";
            Console.WriteLine("static constructor is called");
        }
        public employee(string name, int id)
        {
            this.name = name;
            this.id = id;
            Console.WriteLine("overloaded constructor is called");
        }
        public void printorganisation()
        {
            Console.WriteLine(organisationname);
        }
        public void printname()
        {
            Console.WriteLine(name);
        }
        public void printid()
        {
            Console.WriteLine(id);
        }
    }
}
namespace project1
{
    class program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.printname();
            e.printid();
            e.printorganisation();

        }
    }
}