using System;

class Factorial
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        while (true)
        {
            Console.Write(b);
            if (b <= 1)
            {
                break;
            }
            Console.Write("*");
            factorial *= b;
            b--;
        }
        Console.WriteLine(" n! =" + factorial);
    }
}

