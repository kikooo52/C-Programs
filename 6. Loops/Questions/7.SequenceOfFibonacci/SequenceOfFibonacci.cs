using System;

class SequenceOfFibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        decimal N = decimal.Parse(Console.ReadLine());
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;

        for (int i = 0; i <= N; i++)
        {
            Console.WriteLine("Number:{0} Sum:{1}", i, firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
    }
}
