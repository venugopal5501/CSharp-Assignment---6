using System;

public interface IAccount
{
    void deposit();
    void withdraw();
    void calculateinterest();
    void viewbalance();

}
class BankAccount
{

    public int choice;
    public int[] Account;
    public string[] name;
    public int cur;
    public string type;
    public void add()
    {

        Console.WriteLine("Do you want to create current account or savings account Press 1 for Current and 2 For Savings ");
        cur = Convert.ToInt32(Console.ReadLine());


        if (cur == 1)
        {
            type = "current";
            Console.WriteLine("How many accounts do you want to create ? : ");
            choice = Convert.ToInt32(Console.ReadLine());
            Account = new int[choice];
            name = new string[choice];
            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine("Enter Account Number : ");
                Account[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name : ");
                name[i] = Console.ReadLine();
            }

        }
        if (cur == 2)
        {
            type = "saving";
            Console.WriteLine("How many accounts do you want to create ? : ");
            choice = Convert.ToInt32(Console.ReadLine());
            Account = new int[choice];
            name = new string[choice];
            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine("Enter Account Number : ");
                Account[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name : ");
                name[i] = Console.ReadLine();
            }

        }
    }
    public void display()
    {
        for (int i = 0; i < Account.Length; i++)
        {
            for (int j = 0; j < name.Length; j++)
            {
                if (i == j)
                {
                    Console.WriteLine("Acoount Number : " + Account[i] + " " + "Name : " + name[j]);
                    break;
                }
            }
        }
    }
}



class SavingsAccount : BankAccount, IAccount
{
    public int result = 0;
    public int deposits;

    public int withdraws;
    public int interests;
    public void deposit()
    {
        Console.WriteLine("Enter amount : ");
        deposits = Convert.ToInt32(Console.ReadLine());
        result = result + deposits;
        Console.WriteLine("The amount " + deposits + " deposited in your account");
        Console.WriteLine("The available amount in your account is : " + result);
    }
    public void withdraw()
    {
        Console.WriteLine("Enter amount : ");
        withdraws = Convert.ToInt32(Console.ReadLine());
        result = result - withdraws;
        Console.WriteLine("The amount " + withdraws + " debited in your account");
        Console.WriteLine("The available amount in your account is : " + result);
    }
    public void calculateinterest()
    {
        interests = result * 3;
        Console.WriteLine(interests);
    }
    public void viewbalance()
    {
        Console.WriteLine("The available balance in your account is : " + result * 3);
    }
}

class CurrentAccount : BankAccount, IAccount
{
    public int result = 0;
    public int deposits;

    public int withdraws;
    public int interests;
    public void deposit()
    {
        Console.WriteLine("Enter amount : ");
        deposits = Convert.ToInt32(Console.ReadLine());
        result = result + deposits;
        Console.WriteLine("The amount " + deposits + " deposited in your account");
        Console.WriteLine("The available amount in your account is : " + result);
    }
    public void withdraw()
    {
        Console.WriteLine("Enter amount : ");
        withdraws = Convert.ToInt32(Console.ReadLine());
        result = result - withdraws;
        Console.WriteLine("The amount " + withdraws + " debited in your account");
        Console.WriteLine("The available amount in your account is : " + result);
    }
    public void calculateinterest()
    {
        interests = result ;
        Console.WriteLine(interests);
    }
    public void viewbalance()
    {
        Console.WriteLine("The available balance in your account is : " + result);
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount b = new BankAccount();
        SavingsAccount s = new SavingsAccount();
        CurrentAccount c = new CurrentAccount();

    // b.display();
    l:
        Console.WriteLine("1. create account \n 2. Savings deposit \n 3. current deposit \n 4. Savings withdraw \n 5.Current withdraw \n 6.Saving view balance \n 7.Current view balance \n 8.See Accounts \n 0.Exit ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                b.add();
                goto l;
            case 2:
                s.deposit();
                goto l;
            case 3:
                c.deposit();
                goto l;
            case 4:
                s.withdraw();
                goto l;
            case 5:
                c.withdraw();
                goto l;
            case 6:
                s.viewbalance();
                goto l;
            case 7:
                c.viewbalance();
                goto l;
            case 8:
                b.display();
                goto l;
            case 0:
                return;
        }
    }
}