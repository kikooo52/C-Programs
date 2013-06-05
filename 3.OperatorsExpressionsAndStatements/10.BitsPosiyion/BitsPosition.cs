using System;

class BitsPosition
{
    static void Main(string[] args)
    {

        int five = 5;   //101
        sbyte two = 2; //010
        int change = 1 << two; // 001 < 2 = 100

        Console.WriteLine(change);

        if ((change & five) != 0)      // 100 & 101 !=0 ; 100=4       
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}





















