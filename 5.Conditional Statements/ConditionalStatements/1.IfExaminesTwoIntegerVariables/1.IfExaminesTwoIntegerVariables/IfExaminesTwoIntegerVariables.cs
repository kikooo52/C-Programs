using System;


class IfExaminesTwoIntegerVariables
{
    static void Main()
    {
        int c;

        Console.Write("first bumber:");
        int firstInt = int.Parse(Console.ReadLine());

        Console.Write("second number");
        int secondInt = int.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            c = firstInt;
            firstInt = secondInt;
            secondInt = c;
            Console.WriteLine("firstInt is bigger than secondInd so they have changed:{0}  {1}", firstInt, secondInt);
        }
        else 
        {
            Console.WriteLine("not bigger");
        }

    }
}

