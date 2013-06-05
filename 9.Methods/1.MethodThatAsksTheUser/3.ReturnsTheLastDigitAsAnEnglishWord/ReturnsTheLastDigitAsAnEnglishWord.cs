using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReturnsTheLastDigitAsAnEnglishWord
{
    class ReturnsTheLastDigitAsAnEnglishWord
    {

        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            int lastdigit = number % 10;
            string englishdigit = ReturnLastDigitAsWord(lastdigit);
            PrintWord(englishdigit);
        }

         static void PrintWord(string englishdigit)
        {
            Console.Write("Number:" + englishdigit);
            Console.WriteLine();
        }

         static string ReturnLastDigitAsWord(int lastdigit)
        {
            string englishdigit;
            switch (lastdigit)
            {
                case 0: englishdigit = "Zero"; break;
                case 1: englishdigit = "One"; break;
                case 2: englishdigit = "Two"; break;
                case 3: englishdigit = "Tree"; break;
                case 4: englishdigit = "Four"; break;
                case 5: englishdigit = "Fife"; break;
                case 6: englishdigit = "Sex"; break;
                case 7: englishdigit = "Seven"; break;
                case 8: englishdigit = "Eight"; break;

                default: englishdigit = "Nine"; break;

            }
            return englishdigit;
        }
    }
}
