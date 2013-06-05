using System;

internal class ChecksFiveInteger
{
    private static void Main()
    {
        Console.WriteLine("Will there are subsets equal to zero?");
        Console.WriteLine("Enter five numbers: ");

        int Num1 = int.Parse(Console.ReadLine());
        int Num2 = int.Parse(Console.ReadLine());
        int Num3 = int.Parse(Console.ReadLine());
        int Num4 = int.Parse(Console.ReadLine());
        int Num5 = int.Parse(Console.ReadLine());

        if (Num1 + Num2 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num1, Num2);
        }

        if (Num1 + Num3 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num1, Num3);
        }

        if (Num1 + Num4 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num1, Num4);
        }

        if (Num1 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num1, Num5);
        }

        if (Num2 + Num3 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num2, Num3);
        }

        if (Num2 + Num4 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num2, Num4);
        }

        if (Num2 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num2, Num5);
        }

        if (Num3 + Num4 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num3, Num4);
        }

        if (Num3 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num3, Num5);
        }

        if (Num4 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1} = 0", Num4, Num5);
        }

        if (Num1 + Num2 + Num3 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2} = 0", Num1, Num2, Num3);
        }

        if (Num1 + Num3 + Num4 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2} = 0", Num1, Num3, Num4);
        }

        if (Num1 + Num4 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2} = 0", Num1, Num4, Num5);
        }

        if (Num2 + Num3 + Num4 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2} = 0", Num2, Num3, Num4);
        }

        if (Num2 + Num4 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2} = 0", Num2, Num4, Num5);
        }

        if (Num3 + Num4 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2} = 0", Num3, Num4, Num5);
        }

        if (Num1 + Num2 + Num3 + Num4 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2}, and {3} = 0", Num1, Num2, Num3, Num4);
        }

        if (Num1 + Num3 + Num4 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2}, and {3} = 0", Num1, Num3, Num4, Num5);
        }

        if (Num1 + Num2 + Num3 + Num4 + Num5 == 0)
        {
            Console.WriteLine("Is equal to zero {0}, and {1}, and {2}, and {3}, and {4} = 0", Num1, Num2, Num3, Num4,
                Num5);
        }
    }
}