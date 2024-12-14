using System;
using System.Collections.Generic;
class Bank
{
    public List<object> name = new List<object>();
    // public int accountnumber;
    public int removes;
    //public string names;

    public void add()
    {
        Console.WriteLine("How many accounts do you want to create ? : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        int[] Account = new int[choice];
        string[] names = new string[choice];
        for (int i = 0; i < choice; i++)
        {
            Console.WriteLine("Enter Account Number : ");
            Account[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            names[i] = Console.ReadLine();
            name.Add(Account[i], names[i]);
        }
    }
    public void remove()
    {
        Console.WriteLine("Enter Account Number : ");
        removes = Convert.ToInt32(Console.ReadLine());
        if (name.ContainsKey(removes))
        {
            name.Remove(removes);
        }
        else
        {
            Console.WriteLine("does not exist");
        }
    }
    public void display()
    {
        Console.WriteLine("The available accounts are : ");
        foreach (var acoount in name)
        {

            Console.WriteLine(acoount + " " + " " + acoount.Value);
        }
    }
}


class Account : Bank
{
    public int result = 0;
    public int deposits;

    public int withdraws;

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

}

class Program
{
    public static void Main(string[] args)
    {
        Bank b = new Bank();
        Account a = new Account();
    l:
        Console.WriteLine("1.Add Account \n 2.Remove Account \n 3.Deposit \n 4.Withdraw \n 5.Available Accounts \n 0.Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                b.add();
                goto l;
            case 2:
                b.remove();
                goto l;
            case 3:
                {
                    int no = Convert.ToInt32(Console.ReadLine());
                    foreach (var sam in b.name)
                    {
                        if (sam.Key == no)
                        {
                            a.deposit();

                            if (sam.Key != no)
                            {
                                Console.WriteLine("Not valid");
                            }

                        }
                    }
                    goto l;
                }

            case 4:
                {
                    int no = Convert.ToInt32(Console.ReadLine());
                    foreach (var sam in b.name)
                    {
                        if (sam.Key == no)
                        {
                            a.withdraw();
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }

                    }
                }
                goto l;
            case 5:
                b.display();
                goto l;




        }

    }
}