using System;

class HexValue
{
    static void Main(string[] args)
    {
        int number = 0xFE;
        Console.WriteLine("number is changed {0}", number);

        int @num = number; 
        Console.WriteLine("number {0:X}" , num);
    }
}

