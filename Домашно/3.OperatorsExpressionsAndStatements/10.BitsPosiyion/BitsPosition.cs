using System;

class BitsPosition
{
    static void Main(string[] args)
    {

        int n = 5;   //101
        sbyte p = 2; //010
        int change = 1 << p; // 001 < 2 = 100
        Console.WriteLine(change);
        if ((change & n) != 0)      // 100 & 101 !=0 ; 100=4
         
        {
            Console.WriteLine(true);
        }

        else
        {
            Console.WriteLine(false);
        }

    }
}





















