using System;


class AreaAndPerimerer
{
    static void Main(string[] args)
    {
        decimal Radius = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Area: {0}", (decimal)Math.PI * (Radius * Radius));
        Console.WriteLine("Perimeter: {0}", 2 * (decimal)Math.PI * Radius);
    }
}
