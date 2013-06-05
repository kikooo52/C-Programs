using System;
using System.Collections.Generic;

class N_MaxAndMin
{
    static void Main(string[] args)
    {
        int min = int.MaxValue; // 
        int max = int.MinValue;
        Console.Write("Enter num in interval : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("min {0}, max {1}",min, max);
       

        }
}


