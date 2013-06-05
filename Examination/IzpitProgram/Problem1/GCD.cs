using System;


class IzpitProgram
{
    static void Main(string[] args)
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        if (M !=0 && P!=0)
        {                 
        double sum = (N * N + 1 / (M * P) + 1337) / (N - 128.523123123 * P) + Math.Sin((int)M % 180);
        Console.WriteLine(sum);



        Console.WriteLine(5.99 % 3);
        }
        else
        {
            Console.WriteLine("error, have zero M or P");
        }
    }
}
