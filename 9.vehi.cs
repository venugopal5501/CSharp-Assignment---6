using System;
class Vehicle
{
    public virtual void speedUp()
    {

    }
}

class Car : Vehicle
{
    public int speed;
    public Car(int speed)
    {
        this.speed = speed;
    }
    public override void speedUp()
    {
        Console.WriteLine("In car we can able to travel " + speed + "km per hr");

    }
}

class Bicycle : Vehicle
{
    public int speed;
    public Bicycle(int speed)
    {
        this.speed = speed;
    }
    public override void speedUp()
    {
        Console.WriteLine("In bicycle we can able to travel upto " + speed + "km per hr");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car c = new Car(100);
        Bicycle b = new Bicycle(5);

        c.speedUp();
        b.speedUp();

    }
}