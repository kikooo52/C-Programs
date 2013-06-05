using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 1, 2,4,1, 4, 5,2,2,333};
        int num = 0;
        int len = 1;
        int maxlen = 1;
        for (int i = 1; i < arr1.Length; i++)
        {
            if (arr1[i-1] < arr1[i])
            {
                len++;
                if (len > maxlen)
                {
                    num = i;
                    maxlen = len;
                }
            }
            else
            {
                len = 1;
            }
        }
        for (; maxlen > 0; maxlen--)
        {
           int j = num - maxlen;
            Console.Write(arr1[j+1]+",");

        }
        Console.WriteLine();
    }
}

