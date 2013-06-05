using System;


class OddEven
{
    static void Main(string[] args)
    {
   

        Console.WriteLine("\tenter a:");
        long b = long.Parse(Console.ReadLine());
        Console.WriteLine("\tenter b:");
        long v = long.Parse(Console.ReadLine());
        Console.WriteLine("result:{0}", (b + v) % 2 == 0);
        if ((b + v) % 2 == 0)
        {
            Console.WriteLine("EVEN");
         
        }

        else
        {
            Console.WriteLine("ODD");
      
        }
    }
}

