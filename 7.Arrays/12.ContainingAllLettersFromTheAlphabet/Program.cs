using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ContainingAllLettersFromTheAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.Write(j + ",");
                    }
                }
            }Console.WriteLine();
        }   
    }
}