using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindsTheMostFrequentNumber
{
    static void Main(string[] args)
    {
        int[] arr = { 4, 4, 2, 3, 4, 4, 1, 3, 4, 1, 1, 4, 4, 1, 1, };
        int len = 1;
        int num = 0;
        int maxlen = 1;
        int numptemp = 0;
        while (numptemp < arr.Length)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[numptemp] == arr[j])
                {
                    len++;
                }
                if (len > maxlen)
                {
                    maxlen = len;
                    num = arr[j];
                }
            }
            len = 0;
            numptemp++;
        }
        Console.Write("Most frequent number is {0}, {1} times", num, maxlen);
        Console.WriteLine();
    }
}

