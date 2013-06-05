using System;

class FibonacciNumber
{
    static void Main(string[] args)
    {
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;

        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("Number:{0} Sum:{1}", i, firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            
        }
    }
}
