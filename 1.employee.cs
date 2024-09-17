using System;
class Employee
{
    public virtual void work()
    {
        Console.WriteLine("Work Process will be done here");
    }
    public void getSalary()
    {
        Console.WriteLine("Salary Process will be done here");
    }
    static void demo()
    {
        Console.WriteLine("Demo");
    }
}
class HRManager : Employee
{
    public override void work()
    {
        Console.WriteLine("Reschedule");
    }
    public virtual void addEmployee()
    {
        Console.WriteLine("New Employees will be added here");

    }
}
class Program
{
    static void demo()
    {
        Console.WriteLine("Demo");
    }
    public static void Main(string[] a)
    {
        // Employee em = new Employee();
        HRManager hr = new HRManager();
        // Employee emp = new HRManager();
        // em.work();
        hr.work();
        hr.getSalary();
        hr.addEmployee();
        // emp.work();
        // em.getSalary();
        demo();
    }
}