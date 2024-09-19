using System;
class Airplane
{
    public static void delay()
    {
        Console.Write("Enter Flight Number : ");
        int flightnum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Flight destination : ");
        string destination = Console.ReadLine();
        Console.Write("Enter Flight departure time : ");
        int time = 7;
        int departuretime = Convert.ToInt32(Console.ReadLine());
        int delay = (time - departuretime);
        Console.WriteLine("Flight delay is : " + Math.Abs(delay) + " hr");
        if (time == departuretime)
        {
            Console.WriteLine("Status : On- Time");
        }
        else if (time < departuretime)
        {
            Console.WriteLine("Status : Delayed");
        }
        else if (departuretime == 0)
        {
            Console.WriteLine("Status : Cancelled");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Airplane.delay();
    }
}