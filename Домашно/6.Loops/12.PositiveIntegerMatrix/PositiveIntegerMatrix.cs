using System;

class PositiveIntegerMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        if (N<20 && N>0)
        {           
        for (int i = 1; i <= N; i++)
          {        
            for (int j = i; j < (N+i); j++)
            {
                Console.Write("{0,3}",j);   
            }
            Console.WriteLine();
          }
        }
        else
        {
            Console.WriteLine("Error, N is not in range");
        }
    }
}

