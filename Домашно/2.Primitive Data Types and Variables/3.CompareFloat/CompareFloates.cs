using System;


class CompareFloates
{
    static void Main(string[] args)
    {
        decimal num1 = 6.01m;
        decimal num2 = 5.3m;
        decimal num3 = 5.00000003m;
        decimal num4 = 5.00000001m;
        const decimal precision = 0.000001m;

        Console.WriteLine("The precision is : 0.000001");
        Console.WriteLine("\nRESULT 1 :"+(num1 - num2));
        Console.WriteLine("RESULT 2 :" + (num3 - num4));
        Console.WriteLine("\t\tcompared numbers {1} - {2} are = {0}",
            ((num1 - num2) <= precision), num1, num2);
           

        Console.WriteLine("\n\t\tcompared numbers {1} - {2} are = {0}",
            ((num3 - num4) <= precision), num3, num4);
        
        
    }
}
