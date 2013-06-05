using System;


class BitValue
{
    static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine()); // 5 = 101;

        int b = int.Parse(Console.ReadLine()); // 6 = 110

        int change = 1 << b;  // 001 << 5 = 10000
        if ((i & change) != 0)  // 101 & 10000 = 0
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }

    }
}
