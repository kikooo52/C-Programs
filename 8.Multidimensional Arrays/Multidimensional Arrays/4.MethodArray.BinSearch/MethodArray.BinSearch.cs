using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MethodArrayBinSearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer number {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        int searchednumber = Array.BinarySearch(arr, k);
        foreach (int number in arr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        if (searchednumber < -1)
        {
            Console.WriteLine("Number closest to {0} is {1}", k, arr[~searchednumber - 1]);
        }
        else if (~searchednumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("Number {0} is equal {1}", k, arr[searchednumber]);
        }
    }
}
