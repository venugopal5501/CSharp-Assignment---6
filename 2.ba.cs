using System;
class BankAccount
{
    public int result = 0;

    public void deposit()
    {
        Console.Write("Enter the deposit amount : ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        result = result + deposit;
        Console.WriteLine("Amount is deposited");
        Console.WriteLine("The available balance is : " + result);
    }
    public virtual int withdraw()
    {
        return 1;
    }
}

class SavingsAccount : BankAccount
{
    public int withdraws;

    public override int withdraw()
    {
        if (result >= 1000)
        {
            Console.Write("Enter amount to withdraw : ");
            withdraws = Convert.ToInt32(Console.ReadLine());
            if (result < withdraws)
            {
                Console.WriteLine("You have only " + result);
            }
            else
            {
                result = result - withdraws;
                Console.WriteLine("Your Withdrawl process is completed");
                Console.WriteLine("Your available balance is : " + result);
            }

        }

        return result;

    }
    class Program
    {
        public static void Main(string[] args)
        {

            SavingsAccount sb = new SavingsAccount();
        l:
            Console.Write("Enter 1 for cash deposit or 2 for withdraw or 0 to quit : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    sb.deposit();
                    goto l;

                case 2:
                    sb.withdraw();
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