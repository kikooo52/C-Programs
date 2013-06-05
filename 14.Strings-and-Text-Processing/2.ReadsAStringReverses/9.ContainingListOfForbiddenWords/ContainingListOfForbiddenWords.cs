//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ContainingListOfForbiddenWords
{
    class ContainingListOfForbiddenWords
    {
        private static string stringtext;
        private static string[] forbidenWords;

        static void Main(string[] args)
        {
            ReplacesTheForbiddenWords();
        }

        private static void ReplacesTheForbiddenWords()
        {
            stringtext = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            forbidenWords = new string[] { "Microsoft", "CLR", " PHP " };
            int length = forbidenWords.Length;

            for (int i = 0; i < length; i++)
            {
                stringtext = stringtext.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
            }
            Console.WriteLine(stringtext);
        }
    }
}

