using System;
class add
{
    public int available = 0;
    public int result = 0;
    public void deposit()
    {
        int value = Convert.ToInt32(Console.ReadLine());
        result = available + value;
        Console.Write(result);
    }
    public static void Main(string[] args)
    {
        add a = new add();
l:
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    a.deposit();
                    goto l;


            }
        }

    }
