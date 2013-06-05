//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
//  the rest of the characters should be filled with '*'. Print the result string into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringOfMaximum20Characters
{
    class StringOfMaximum20Characters
    {
        private static StringBuilder stringChars = new StringBuilder();

        static void Main(string[] args)
        {
            CheckLengthIfEqualOnTwenty();
        }

        private static void CheckLengthIfEqualOnTwenty()
        {
            Console.Write("Enter 20 chars of strig:");
            stringChars = new StringBuilder(Console.ReadLine());
            if (stringChars.Length > 20)
            {
                Console.WriteLine("Have to be less of Twenty");
            }
            else
            {
                for (int i = stringChars.Length; i < 20; i++)
                {
                    stringChars.Append('*');
                }
                Console.WriteLine(stringChars.ToString());
            }
        }
    }
}
