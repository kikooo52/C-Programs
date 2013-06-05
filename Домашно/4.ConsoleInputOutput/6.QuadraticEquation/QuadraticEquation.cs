using System;


class QuadraticEquation
{
    static void Main(string[] args)
    {


        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double d = b * b - (4 * a * c);
        double x1, x2;
        {
            x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
            x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("the equision has two roots: {0} and {1}.", x1, x2);
        }
    }
}


