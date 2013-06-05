using System;


    class NumbersDivisibleBy_3_And_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The number \"{0}\" is not divide on 3 and 7", i); 
            }
        }
        }
    }