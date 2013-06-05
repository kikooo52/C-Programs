using System;

class ShowsThreeRealNumbersWithoutCalculating
{
static void Main()
{
    Console.Write("Enter num1:");
    int Num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter num2:");
    int Num2 = int.Parse(Console.ReadLine());

    Console.Write("Enter num3:");
    int Num3 = int.Parse(Console.ReadLine());

    int Result = 0;

    if (Num1 == 0 || Num2 == 0 || Num3 == 0)
    {
        Console.WriteLine("The product is zero");
        return;
    }

    if (Num1 < 0)
    {
        Result++;
    }

    if (Num2 < 0)
    {
        Result++;
    }

    if (Num3 < 0)
    {
        Result++;
    }        

    if (Result % 2 == 0)
       {
            Console.WriteLine("The product is a positive number");
        }
    else
        {
            Console.WriteLine("The product is a negative number");
        }

}
}

