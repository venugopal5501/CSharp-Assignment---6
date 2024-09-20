using System;
class sum
{
    public static void Main(string[] args)
    {
    l:
        Console.Write("Enter the number of elements you want to process: ");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[length];
        int average;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] > 100)
            {
                Console.WriteLine("Please enter number between 1 to 100");
                i--;
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");

        }
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 100)
            {
                sum = sum + arr[i];
            }
            else
            {
                break;
            }

        }
        average = sum / length;
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is " + average);
        goto l;

    }
}