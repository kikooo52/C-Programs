using System;


class QuadraticEquation
{
    static void Main(string[] args)
    {
        double x1, x2;
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double c = int.Parse(Console.ReadLine());
        double D = (b * b) - 4 * (a * c);
        if (D == 0)
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("There is one real root: {0}", x1);
        }
        if (D <0)
        {
            Console.WriteLine("There isn't real roots ");
        }
        if (D > 0)  
        {
            x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
            x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("Root \"x1\": {0}, and \"x2\":{1}",x1, x2);
        }       

    }
}
