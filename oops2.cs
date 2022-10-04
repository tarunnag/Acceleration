using project;
using System;
namespace project
{
    class employee
    {
        public static void printorganisation()
        {
            Console.WriteLine("moback");
        }
        public employee()
        {
            name = "tarun";
            id = 20;
        }
        public string name;
        public int id;
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
            employee emp = new employee();
            emp.name = "nag";
            emp.id = 30;
            emp.printname();
            emp.printid();
            employee emp1 = new employee();
            emp1.name = "mujeeb";
            emp1.id = 30;
            emp1.printname();
            emp1.printid();
            employee.printorganisation();
        }
    }
}