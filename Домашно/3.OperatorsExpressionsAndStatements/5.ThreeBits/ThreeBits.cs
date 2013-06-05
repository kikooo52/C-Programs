using System;

class ThreeBits
{
    static void Main(string[] args)
    {
        byte a = 8;
        ulong b = ulong.Parse(Console.ReadLine());
        Console.WriteLine((a & b) == 0 ? "the third bit is 0" : "the third bit is 1"); 

    }
}

