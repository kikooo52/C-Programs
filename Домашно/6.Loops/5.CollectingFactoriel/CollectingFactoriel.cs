using System;

class DividingFactoriel
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter positive integer 1<N<K ! ");
        Console.Write("Enter K : ");
        double K = double.Parse(Console.ReadLine());
        Console.Write("Enter N : ");
        double N = double.Parse(Console.ReadLine());
        double Nfactoriel = 1;
        double Kfactoriel = 1;
        double NKfactoriel = 1;
        double KN = K - N;
        if (K > N)
        {          
        for (double i = 1; i <= N; i++)
        {
            Nfactoriel *= i;
        }
        for (double j = 1; j <= K; j++)
        {
            Kfactoriel *= j;
        }
        for (double k = 1; k <= KN; k++)
        {
            NKfactoriel *= k;
        }
        Console.WriteLine("N!*K!/(K-N)! = " + Nfactoriel * Kfactoriel / NKfactoriel);
        }
        else
        {
            Console.WriteLine("\nError K < N");
        }
    }
}
        

