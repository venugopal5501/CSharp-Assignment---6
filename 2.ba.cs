using System;
class BankAccount
{
    public int result = 0;

    // public BankAccount(int available)
    // {
    //     this.available = available;
    // }

    public void deposit(int available)
    {
        Console.Write("Enter the deposit amount : ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        result = available + deposit;
        Console.WriteLine("Amount is deposited");
        Console.WriteLine("The available balance is : " + result);
    }
    public virtual void withdraw(int ava)
    {

    }
}

class SavingsAccount : BankAccount
{
    public int minus ;
    // public int ava;
    // public SavingsAccount(int ava)
    // {
    //     this.ava = ava;

    // }
    public override void withdraw(int ava)
    {
        if (minus >= 1000)
        {
            Console.Write("Enter amount to withdraw : ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            minus = ava - withdraw;
            Console.WriteLine("Your Withdrawl process is completed");
            Console.WriteLine("Your available balance is : " + minus);
        }

        // withdraw(BankAccount.minus);


        // if (result < 1000)
        // {
        //     Console.WriteLine("invalid Balance");
        // }
        // if (result < 0)
        // {
        //     Console.WriteLine("invalid Balance");
        // }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            // BankAccount ba = new BankAccount();
            SavingsAccount sb = new SavingsAccount();



        l:
            Console.Write("Enter 1 for cash deposit or 2 for withdraw or 0 to quit : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    sb.deposit(sb.result);
                    goto l;

                case 2:
                    // SavingsAccount sb = new SavingsAccount(ba.result);
                    // ba.withdraw(sa.result);
                    sb.minus=sb.result;
                    sb.withdraw(sb.minus);
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
}