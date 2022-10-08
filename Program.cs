using System;
public class Restaurant
{
    private string name;
    private string address;
    private double gratuityRate;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public double GratuityRate
    {
        get { return gratuityRate; }
        set
        {
            if (value > 0)
            {
                gratuityRate = value;
            }
        }
    }
    public Restaurant(string name, string address, double gratuityRate)
    {
        Name = name;
        Address = address;
        GratuityRate = gratuityRate;
    }
    public void GenerateReceipt()
    {
        double price = 0;
        double sub_total=0;
        double gratuityamount=0;
        double grand_total;
        int people;
        while (price != -1)
        {
            sub_total = sub_total + price;
            Console.WriteLine("enter the price of the item:");
            price = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("how many are in the party");
        people = Convert.ToInt32(Console.ReadLine());
        if (people>=6)
        {
            gratuityamount = sub_total * gratuityRate;
        }
        grand_total = sub_total + gratuityamount;
        Console.WriteLine( sub_total);
        Console.WriteLine(gratuityamount);
        Console.WriteLine( grand_total);
    }
}
