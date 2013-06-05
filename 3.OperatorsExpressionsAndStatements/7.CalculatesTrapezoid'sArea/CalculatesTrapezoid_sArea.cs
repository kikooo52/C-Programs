using System;

class CalculatesTrapezoid_sArea
{
    private static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float h = float.Parse(Console.ReadLine());

        Console.WriteLine("the area is: {0}", (a + b)/2*h); //7+7=14/2=7*h 
    }
}