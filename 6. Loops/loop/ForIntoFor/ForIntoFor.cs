using System;

class ForIntoFor
{
    static void Main(string[] args)
    {
        Console.Write("Enter t :");
        int t = int.Parse(Console.ReadLine());

        for (int row = 1; row <= t; row++)
        {
            Console.Write(new String(' ', 2 * (t - row)));
            for (int col = 1; col <= row; col++)
            {
                Console.Write("{0,-4}", col);
            }
            Console.WriteLine();
           
        }       
    }
}

       
