using System;

class FindsTheBiggestThree
{
    static void Main(string[] args)
    {
            int firstNum = int.Parse(Console.ReadLine()); 
            int secondNum = int.Parse(Console.ReadLine()); 
            int thirdNum = int.Parse(Console.ReadLine()); 

        if (firstNum < secondNum)
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("The biggest num is {0}", secondNum);
            }
            else
            {
                Console.WriteLine("The biggest num is {0}", thirdNum);
            }

        }
        else 
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("The biggest num is {0}", firstNum);
            }
            else
            {
                Console.WriteLine("The biggest num is {0}", thirdNum); 
            }
       }
    }
}

