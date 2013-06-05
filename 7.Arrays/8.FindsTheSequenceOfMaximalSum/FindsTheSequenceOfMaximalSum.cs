using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
class FindsTheSequenceOfMaximalSum
{
    static void Main()
    {

        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -1, -8,8 };       
        int maxsum = arr[0];
        int maxend = arr[0];
        int begin = 0;
        int end = 0;
        int begintemp = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            maxend += arr[i];
            if (arr[i] > maxend)
            {
                maxend = arr[i];
                begintemp = i;
            }
            if (maxend > maxsum)
            {
                maxsum = maxend;
                begin = begintemp;
                end = i;
            }

        }
        for (int i = begin; i < end+1; i++)
        {
            Console.Write(arr[i]+",");
        }
        Console.WriteLine();
    }
}