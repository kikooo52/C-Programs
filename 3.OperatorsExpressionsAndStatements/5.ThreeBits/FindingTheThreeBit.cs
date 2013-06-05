using System;

class ThreeBits
{
    static void Main(string[] args)
    {
        byte eight = 8;

        ulong number = ulong.Parse(Console.ReadLine());

        Console.WriteLine((eight & number) == 0 ? "the third bit is 0" : "the third bit is 1"); 
    }
}

