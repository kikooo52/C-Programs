using System;


class IzpitProgram
{
    static void Main(string[] args)
    {
        Console.Write("Entrer x :");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Entrer y :");
        int y = int.Parse(Console.ReadLine());

        while (x != y)
        {
            if (x > y)
            {
                x = x - y;
            }
            else
            {
                y = y - x;
            }
        }
        Console.WriteLine("GCD = " +x);
          
       
    }
}
