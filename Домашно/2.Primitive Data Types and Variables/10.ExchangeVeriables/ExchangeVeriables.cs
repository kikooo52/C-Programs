using System;

class ExchangeVeriables
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("{0}\n{1}", a,b);
    }
}

