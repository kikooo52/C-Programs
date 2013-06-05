using System;

class PythagoreanTheorem
{
    static void Main(string[] args)
    {
        int radius = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
         if ((x * x) + (y * y) <= radius * radius)
         {
             Console.WriteLine("The point is inside the circle");
         }
         else
         {
             Console.WriteLine("The point is outside the circle");
         }
    }
}

