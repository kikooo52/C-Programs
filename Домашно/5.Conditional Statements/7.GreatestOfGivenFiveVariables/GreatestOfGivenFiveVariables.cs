using System;


class GreatestOfGivenFiveVariables
{
    static void Main(string[] args)
    {
        decimal num = 0;
            for (int i = 0; i<5; i++)
        {
            Console.Write("Enter the number: ");
            decimal greater = int.Parse(Console.ReadLine());
            if (num < greater)
            {
                num = greater;
                Console.WriteLine("\nThe greater number is:{0}\n", greater);
            }
            else
            {
                Console.WriteLine("{0} is less than {1}, so {1} is greater", greater, num);
            }
        }


    }
}

