using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearchAlgorithm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number thats will search:");
        int num = int.Parse(Console.ReadLine());
        int[] arr = new int[100];
        int bottomline = arr.Length;
        int topline = 0;
        int middleline = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        while (num <= bottomline)
        {
            middleline = (bottomline + topline) / 2;
            if (num == arr[middleline])
            {
                break;
            }
            if (num < arr[middleline])
            {
                bottomline = middleline;
            }
            else
            {
                topline = middleline;
            }
        }
        Console.WriteLine("Position of array is {0}", middleline);
    }
}