using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindsInGivenArrayOfIntegersASequence
{
    static void Main(string[] args)
    {     
        int[] arr = { 4, 3, 1, 3, 2, 5, 8 };
        int num = 0;
        int newnum = 0;
        int len = 0;
        int newlen = 0;
        Console.Write("Enter S: ");
        int digit = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                num +=arr[j];
                
                if (num == digit)
                {
                    newnum = num;
                    len = j;
                    newlen = i;
                }
            }
            num = 0;
        }
        if (len == 0)
        {
            Console.WriteLine("There is't sequence");
            return;
        }
        for (int i = newlen; i < len+1; i++)
        {
            Console.Write( arr[i] + ",");
        }
        Console.WriteLine();

    }
}

