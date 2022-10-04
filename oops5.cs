using System;
namespace project
{
    public class employee
    {
        public string FirstName;
        public string LastName;
        public employee()
        {
            Console.WriteLine("base constructor");
        }
        public employee(string a)
        {
            FirstName = a;
            LastName = a;
            Console.WriteLine("string overloaded");
        }
        public employee(int b)
        {
            Console.WriteLine("overloaded integer");
        }
        public virtual void FullName()
        {
            Console.WriteLine(FirstName + LastName );
        }
    }
    public class FullEmployee : employee
    {
        public FullEmployee()
        {
            Console.WriteLine("derived constructor");
        }
        public override void FullName()
        {
            Console.WriteLine("full employee" +FirstName + LastName);
        }
        public int MontlySalary;
    }
    public class PartEmployee : employee
    {
        public PartEmployee():base("tarun")
        {
            Console.WriteLine("derived two Constructor");
            base.FullName();
        }
        public int HourlySalary;
        public override void FullName()
        {
            Console.WriteLine("part time employee "+FirstName + LastName);
            base.FullName();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            //FullEmployee emp = new FullEmployee();
            //emp.FirstName = "Tarun";
            //emp.LastName = "nag";
            //emp.MontlySalary = 100000;
            //emp.FullName();
            //Console.WriteLine(emp.MontlySalary);
            //PartEmployee p = new PartEmployee();
            //p.FirstName = "Boyina";
            //p.LastName = "nag";
            //p.HourlySalary = 2000;
            //p.FullName();
            //Console.WriteLine(p.HourlySalary);
            employee pte = new PartEmployee();
            employee fte = new FullEmployee();
            pte.FullName();
            fte.FullName();
        }
    }
}