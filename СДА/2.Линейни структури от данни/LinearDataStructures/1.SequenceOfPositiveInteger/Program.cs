using System;
using System.Collections.Generic;

namespace _1.SequenceOfPositiveInteger
{
    class Program
    {
        static void Main()
        {
            List<int> someList = new List<int>();      

            while (true)
            {
                string number = Console.ReadLine();

                if (number == string.Empty)
                {
                   break;
                }
                else
                {
                    someList.Add(int.Parse(number));
                }
            }

            Console.WriteLine(Sum(someList));
            Console.WriteLine(Average(someList));
        }

        private static int Sum(List<int> someList)
        {
            int sum = 0;

            foreach (var item in someList)
            {
                sum += item;
            }
            return sum;
        }

        private static int Average(List<int> someList)
        {
            int sum = 0;

            foreach (var item in someList)
            {
                sum += item;
            }

            sum = sum / someList.Count;
            return sum;
        }
    }
}
