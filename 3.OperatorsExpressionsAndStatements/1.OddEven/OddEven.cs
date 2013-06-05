using System;

class OddEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tenter number:");
        long number = long.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("EVEN");     
        }
        else
        {
            Console.WriteLine("ODD");   
        }
    }
}

