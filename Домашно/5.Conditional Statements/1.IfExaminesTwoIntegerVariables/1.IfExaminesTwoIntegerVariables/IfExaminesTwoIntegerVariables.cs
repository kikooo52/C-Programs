using System;


class IfExaminesTwoIntegerVariables
{
    static void Main(string[] args)
    {
        int c;
        int firstInt = int.Parse(Console.ReadLine());
        int secondInd = int.Parse(Console.ReadLine());
        if (firstInt > secondInd)
        {
            c = firstInt;
            firstInt = secondInd;
            secondInd = c;
            Console.WriteLine("firstInt is bigger than secondInd so they have changed:{0}  {1}", firstInt, secondInd);
        }
        else 
        {
            Console.WriteLine("not bigger");
        }

    }
}

