using System;

class Area
{
    static void Main()
    {
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter width");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Area is :{0}", height * width);
    }
}

