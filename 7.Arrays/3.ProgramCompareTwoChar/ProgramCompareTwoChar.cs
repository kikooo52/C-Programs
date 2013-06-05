using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03ComparesArraysLexicographically
{
    class ComparesArraysLexicographically
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'r', 'd', 'r', };
            char[] arr2 = { 'a', 'r', 'd', 'r','a' };
            int maxlenght;
            if (arr.Length <= arr2.Length)
            {
                maxlenght = arr.Length;
            }
            else
            {
                maxlenght = arr2.Length;
            }
            for (int i = 0; i < maxlenght; i++)
            {
                if (arr[i] > arr2[i])
                {
                    Console.WriteLine("second is earlier");
                    return;
                }
                else if (arr[i] < arr2[i])
                {
                    Console.WriteLine("first is earlier");
                    return;
                }
                if (arr.Length > arr2.Length)
                {
                    Console.WriteLine("The second array is earlier.");
                    return;
                }
                else if (arr.Length < arr2.Length)
                {
                    Console.WriteLine("The first array is earlier.");
                    return;
                }
            }
            Console.WriteLine("is equal!");
        }
    }
}