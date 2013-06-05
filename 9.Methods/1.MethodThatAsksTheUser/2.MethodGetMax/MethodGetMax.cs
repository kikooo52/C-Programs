using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MethodGetMax
{
    class MethodGetMax
    {
        static int GetMax(int firstnum, int secondnum)
        {
            return firstnum > secondnum ? firstnum : secondnum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            int bigNumber = GetMax(firstNumber, secondNumber);
            bigNumber = GetMax(bigNumber, thirdNumber);
            Console.WriteLine(bigNumber);
        }
    }
}
