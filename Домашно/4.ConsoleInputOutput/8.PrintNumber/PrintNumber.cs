using System;


class PrintNumber
{
    static void Main(string[] args)
    {
        Console.Write("Write int num :");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

