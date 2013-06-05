using System;

class Prime
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = true;

        if (n > 0 && n < 100)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++) // 
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine("is prime ? : {0}", prime);
        }
        else
            Console.WriteLine("the number is bigger");
    }
}

