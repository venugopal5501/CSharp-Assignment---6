using System;
class Vehicle
{
    private int make;
    public int Make
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
    public virtual void FuelEfficiency()
    {

    }
    public virtual void DistanceTravelled()
    {

    }
    public virtual void MaximumSpeed()
    {

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

        t.Make = 2010;
        t.Model = "Thar";
        t.Year = 2012;
        t.Fuel = "Petrol";
        c.Make = 2010;
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
    }
}


