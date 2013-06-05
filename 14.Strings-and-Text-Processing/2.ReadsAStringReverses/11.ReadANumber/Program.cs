//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.ReadANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                  CultureInfo.GetCultureInfo("en-US");
            Console.Write("Enter number:");
            int someNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", someNumber);
            Console.WriteLine("{0,15:X}", someNumber);
            Console.WriteLine("{0,15:P}", someNumber);
            Console.WriteLine("{0,15:C}", someNumber);

        }
    }
}
