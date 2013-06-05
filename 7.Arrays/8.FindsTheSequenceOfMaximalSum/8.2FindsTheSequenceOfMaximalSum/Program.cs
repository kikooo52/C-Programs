using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2FindsTheSequenceOfMaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 26, -55, -5, -1, -2, 33 };
            int currentSum = 0;
            int begin = 0;
            int end = 0;
            int begintemp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum > begintemp)
                    {
                        begintemp = currentSum;
                        begin = i;
                        end = j;
                    }
                }
            }
            for (int i = begin; i <= end; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }
    }
}
