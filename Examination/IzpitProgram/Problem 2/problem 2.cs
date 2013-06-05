using System;

class GCD
{
    static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.Write("Enter d: ");
        decimal d = decimal.Parse(Console.ReadLine());
        Console.Write("Enter f: ");
        decimal f = decimal.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i < int.MaxValue; i++)
        {
            if (i % a == 0)
            {
                counter++;
            }
            if (i % b == 0)
            {
                counter++;
            }
            if (i % c == 0)
            {
                counter++;
            }
            if (i % d == 0)
            {
                counter++;
            }
            if (i % f == 0)
            {
                counter++;
            }
            if (counter == 3 || counter == 4 || counter==5)
            {
                Console.WriteLine("Diliver is: "+ i);
                break;
            }
            else
            {
                counter = 0;
            }    
        }

    }
}

