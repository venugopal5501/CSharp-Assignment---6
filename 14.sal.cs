using System;

class loan
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter gross monthly income: ");
        int gross = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly tax deducted: ");
        int tax = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly grocery expenses: ");
        int grocery = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly water expenses: ");
        int water = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly electricity expenses: ");
        int electricity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly travel costs: ");
        int travel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly cell phone expenses: ");
        int cell = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter estimated monthly other expenses: ");
        int other = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you want to rent or buy a property? Press 0 for rent or Press 1 for buy ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 0)
        {
            Console.WriteLine("Enter monthly rental amount : ");
            int rent = Convert.ToInt32(Console.ReadLine());
            int remaining = gross - tax - grocery - water - electricity - travel - cell - other - rent;
            Console.WriteLine("Remaining income after rent: " + remaining);

            if (choice == 1)
            {
                Console.WriteLine("Enter purchase price of the property: ");
                double prop = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter total deposit: ");
                double deposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("interest rate (%): ");
                double rate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of months to repay (between 240 and 360): ");
                int months = Convert.ToInt32(Console.ReadLine());
                double monthlyInterestRate = (rate / 12) / 100;
                Console.WriteLine("Monthly interest rate: {0}", monthlyInterestRate);

                double principal = prop - deposit;
                double monthlyPayment = principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, months) / (Math.Pow(1 + monthlyInterestRate, months) - 1);
                // else if (gross < monthlyPayment)
                // {
                //     Console.WriteLine("not");
                // }
                // Console.WriteLine("Monthly repayment is :{0} ", monthlyPayment);

                if (remaining < monthlyPayment)
                {
                    Console.WriteLine("Loan approval is unlikely.");
                }
                else
                {
                    Console.WriteLine("Monthly payment: {0:C}", monthlyPayment);
                }
            }
        }
    }
}