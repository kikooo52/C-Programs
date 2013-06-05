using System;

class GreaterNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter num a:");
        int numA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num b:");
        int numB = int.Parse(Console.ReadLine());
        Console.WriteLine((numA >= numB) ? "a > b" : "b > a");
    }
}
