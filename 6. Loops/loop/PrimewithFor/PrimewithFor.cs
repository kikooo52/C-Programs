using System;

class PrimewithFor
{
    static void Main(string[] args)
    {
        // Prosto chislo
        Console.Write("Enter the positive number: ");
        int bum = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(bum);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (bum % divider == 0)
            {
                 prime = false;
                Console.WriteLine("Found divider : {0}*{1}={2}", divider, bum / divider, bum);

            }
            divider++;
        }
        Console.WriteLine("prime: ?" + prime);

    }
}

