//Write a program that extracts from a given text all sentences containing given word 	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _8.ExtractsFromAGivenText
{
    class ExtractsFromAGivenText
    {
        private static string someText;
        private static string key;
        private static int currentDotIndex;
        private static string currentStr;

        static void Main(string[] args)
        {
            someText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            key = "in";

            for (int i = 0; i < someText.Length; i++)
            {
                currentDotIndex = someText.IndexOf(".", i);
                currentStr = someText.Substring(i, currentDotIndex - i + 1);
                if (Regex.IsMatch(currentStr, @"\b" + key + @"\b."))
                {
                    Console.WriteLine(currentStr);
                }

                i = currentDotIndex + 1;
            }
        }
    }
}
