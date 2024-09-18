using System;
class Vehicle
{
    private string make;
    public string Make
    {
        get { return make; }
        set { make = value; }
    }
    private string model;
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    private int year;
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    private string fuel;
    public string Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }
    public virtual int FuelEfficiency()
    {
        Console.Write("Enter the distance traveled : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter How much fuel consume : ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a / b;
        return c;

    }
    public virtual int DistanceTravelled()
    {
        Console.Write("Enter the speed: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the time: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a * b;
        return c;

    }
    public virtual void MaximumSpeed()
    {
        Console.Write("The Maximum speed of truck is : 110km/h");
    }
}

class Truck : Vehicle
{


}

class Car : Vehicle
{

}

class Motorcycle : Vehicle
{

}

class Program
{
    public static void Main(string[] args)
    {
        Truck t = new Truck();
        Car c = new Car();

        t.Make = "ford";
        t.Model = "Thar";
        t.Year = 2012;
        t.Fuel = "Petrol";
        c.Make = "2010";
        c.Model = "Thar";
        c.Year = 2012;
        c.Fuel = "Petrol";
        Console.WriteLine(t.Make);
        Console.WriteLine(t.Model);
        Console.WriteLine(t.Year);
        Console.WriteLine(t.Fuel);

        Console.WriteLine(c.Make);
        Console.WriteLine(c.Model);
        Console.WriteLine(c.Year);
        Console.WriteLine(c.Fuel);

        int FuelEfficiency = t.FuelEfficiency();

        int DistanceTravelled = t.DistanceTravelled();
        Console.WriteLine("Fule Efficiency for truck is : " + FuelEfficiency);
        Console.WriteLine("The distance travelled by the truck is : " + DistanceTravelled);
        t.MaximumSpeed();
    }
}


