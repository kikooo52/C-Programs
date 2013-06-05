using System;

class GivenTwoIntegerNumbersNandX
{
    static void Main(string[] args)
    {
        Console.Write("Enter X:");
        double X = double.Parse(Console.ReadLine());
        Console.Write("Enter N:");
        double N = double.Parse(Console.ReadLine());
        double factoriel = 1;
        double degree = 1;
        double sum = 1;

        if ((N < 0) || (X < 0))
        {
            Console.WriteLine("Not Integer !");
        }
        else
        {
            for (double i = 1; i <= N; i++)
            {
                factoriel *= i;              
                Console.WriteLine(degree);
                degree *= X;
                sum += factoriel / degree;


            }
            Console.WriteLine("S = "+ sum);
        }
    }
}

