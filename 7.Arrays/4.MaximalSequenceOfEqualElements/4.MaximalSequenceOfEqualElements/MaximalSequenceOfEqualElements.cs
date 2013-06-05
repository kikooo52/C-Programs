using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 3, 3, 4, 4, 4, 4, 5, 22,22,22,22,8 };
        int num = 0;
        int maxnum = 0;
        int len = 1;
        int maxlen = 0;
        for (int i = 1; i < arr1.Length; i++)
        {
            if (arr1[i - 1] == arr1[i])
            {
                num = arr1[i];
                len++;
                if (len >= maxlen)
                {
                    if (num > maxnum)
                    {
                        maxnum = num;
                        maxlen = len;
                    }
                    maxlen = len;
                    maxnum = num;
                }
            }
            else
            {

                len = 1;
            }

        }
        Console.WriteLine("Maximal sequence of:{0}, Digit:{1}", maxlen, maxnum);
       
    }
}
