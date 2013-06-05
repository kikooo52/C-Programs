using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        while (sum<10)
        {
            for (int i = 0; i <= 2; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
    }
}

