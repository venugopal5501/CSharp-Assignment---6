using System;
class BankAccount
{
    public int result;
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
            int minus = result - withdraw;
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
            Console.Write("invalid Balance");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount sa = new SavingsAccount();
        BankAccount ba = new BankAccount();
        Console.Write("Enter 1 for cash deposit or 2 for withdraw : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
            if (choice == 1)
            {
                sa.deposit(100);
            }
            if (choice == 2)
            {
                ba.withdraw(sa.result);
                sa.withdraw(sa.result);
            }
        }
    
}