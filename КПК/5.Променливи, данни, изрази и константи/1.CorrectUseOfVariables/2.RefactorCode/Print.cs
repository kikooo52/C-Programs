using System;
using System.Linq;

namespace RefactorCode
{
   public class Print
    {
        public Print()
        {
        }

        public void PrintStatistics(double[] arr)
        {
            int count = arr.Length;
            double max = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            PrintMax(max);

            double min = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < max)
                {
                    min = arr[i];
                }
            }
            PrintMin(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }
            PrintAvg(sum / count);
        }

        public void PrintMax(double max)
        {
            Console.WriteLine(max);
        }

        public void PrintMin(double min)
        {
            Console.WriteLine(min);
        }

        public void PrintAvg(double max)
        {
            Console.WriteLine(max);
        }

        static public void Main(string[] args)
        {
            double[] someArray = { 4, 123, 32, 1 };
            Print ss = new Print();
            ss.PrintStatistics(someArray);
        }
    }
}
