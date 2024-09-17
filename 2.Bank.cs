using System;
class BankAccount
{
    public int result = 0;
    public int minus = 0;
    public void deposit(int available)
    {

        Console.Write("Enter the deposit amount : ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        result = available + deposit;
        Console.WriteLine("Amount is deposited");
        Console.WriteLine("The available balance is : " + result);
    }

    public virtual void withdraw(int result)
    {
        if (result >= 1000)
        {
            Console.Write("Enter amount to withdraw : ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            minus = result - withdraw;
            Console.WriteLine("Your Withdrawl process is completed");
            Console.WriteLine("Your available balance is : " + minus);
        }
    }
}

class SavingsAccount : BankAccount
{
    public override void withdraw(int result)
    {
        if (result < 1000)
        {
            Console.WriteLine("invalid Balance");
        }
        if (result < 0)
        {
            Console.WriteLine("invalid Balance");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount sa = new SavingsAccount();
        BankAccount ba = new BankAccount();
    l:
        Console.Write("Enter 1 for cash deposit or 2 for withdraw or 0 to quit : ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                sa.deposit(sa.result);
                goto l;
            case 2:
                ba.withdraw(sa.result);
                sa.withdraw(sa.result);
                goto l;
            case 0:
                Console.WriteLine("Thank You");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                goto l;

        }
    }
}