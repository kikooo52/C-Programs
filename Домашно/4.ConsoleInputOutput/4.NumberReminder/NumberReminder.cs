using System;


class NumberReminder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        int b = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("p({0},{1}) = {2}", a, b, counter);

    }
}

