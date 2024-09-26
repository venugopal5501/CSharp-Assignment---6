using System;
class Program
{
    static void Main(string[] args)
    {

        string word = Console.ReadLine();
        string test = Console.ReadLine();
        int count = 0;
        if (word.Length == test.Length)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char current = word[i];


                for (int j = i + 1; j < test.Length; j++)
                {
                    char t = word[j];
                    if (t == current)
                    {
                        count = 1;

                    }
                    Console.WriteLine("{0}{1}", current, count);
                Console.WriteLine("{0}{1}", t, count);
                }
                
            }
            if (count == 1)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("n");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}