using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CountHowManyTimesGivenNumberAppears
{
  public  class CountHowManyTimesGivenNumberAppears
    {
      private static int[] setOfNumbersForSearching = { 12, 2, 2, 11, 2, 3, 2, };
      private static int ourCounter;

      public static void Main(string[] args)
        {
            Console.WriteLine("Enter number that will search:");
            int digitForSearch = int.Parse(Console.ReadLine());
            CountHowManyTimesGivenNumber(out ourCounter, digitForSearch);
            PrintAppearNumber(digitForSearch, ourCounter);
        }

      public static void PrintAppearNumber(int digitForSearch, int ourCounter)
        {
            Console.Write("Number {0}, appear {1} ", digitForSearch, ourCounter);
            Console.WriteLine();
        }

      public static void CountHowManyTimesGivenNumber(out int counter, int digitForSearch)
        {
           
            counter = 0;

            for (int i = 0; i < setOfNumbersForSearching.Length; i++)
            {
                if (digitForSearch == setOfNumbersForSearching[i])
                {
                    counter++;
                }
            }
        }
    }
}
