using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConvertDecimalNumbers
{
    class ConvertDecimalNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int len = ConvertToBinary(ref num, arr);
            PrintBinary(arr, len);
        }

        private static void PrintBinary(int[] arr, int len)
        {
            for (int i = len - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        private static int ConvertToBinary(ref int num, int[] arr)
        {
            int len = 0;
            for (int i = 0; num > 0; i++)
            {
                arr[i] = num % 2;
                num = num / 2;
                len++;
            }
            return len;
        }
    }
}
