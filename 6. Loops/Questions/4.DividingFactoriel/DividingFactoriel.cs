using System;

class    DividingFactoriel
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N : ");
            double N = double.Parse(Console.ReadLine());
            Console.Write("Enter K : ");
            double K = double.Parse(Console.ReadLine());
            double factorialN = 1;
            double factorialK = 1;
            if (K<N)
            {
            while (true)
            {
                if (N <= 1)
                {
                    break;
                }
                else
                {
                    factorialN *= N;
                    N--;
                }
            }
            while (true)
	        {
                if (K <= 1)
                {
                    break;
                }
                else
                {                   
                    factorialK *= K;
                    K--;
                }           
            }
            Console.WriteLine("\nDividing N! / K! :" + factorialN / factorialK);
            }
              else
	            {
                    Console.WriteLine("K is bigger");
	            }
        }      
}
        

    

