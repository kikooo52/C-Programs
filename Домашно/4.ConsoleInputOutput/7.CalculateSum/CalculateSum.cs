using System;


class CalculateSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            sum += num;
        }
        Console.WriteLine(sum);
    }
}

