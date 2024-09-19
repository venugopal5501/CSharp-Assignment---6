using System;
class Employee
{
    public virtual void CalculateSalary()
    {
        Console.Write("Employee salary calculations will be done here");
    }
}
class Manager : Employee
{
    public override void CalculateSalary()
    {
        Console.Write("Enter your base salary : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your year of experience : ");
        int experience = Convert.ToInt32(Console.ReadLine());
        int calc = salary + (experience * 5000);
        Console.Write("Your salary is : " + calc);
    }

}

class Programmer : Employee
{
    public override void CalculateSalary()
    {
        Console.Write("Enter your base salary : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your year of experience : ");
        int experience = Convert.ToInt32(Console.ReadLine());
        int calc = salary + (experience * 2500);
        Console.Write("Your salary is : " + calc);
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your role : ");
        string role = Console.ReadLine();
        Manager MA = new Manager();
        Programmer PM = new Programmer();
        if (role.Equals("Manager"))
        {
            MA.CalculateSalary();
        }
        if (role.Equals("Programmer"))
        {
            PM.CalculateSalary();
        }

    }
}