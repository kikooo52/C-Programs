using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoArrayEqual
{
    static void Main(string[] args)
    {


        int[] arr = { 3, 3, 3, 32, 1, 43, 3, 3, 2, 3, };
        int[] arr2 = { 3, 3, 3, 32, 1, 43, 3, 3, 2, 3, };
        bool a = true;
        if (arr.Length == arr2.Length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr2[i])
                {
                    a = false;
                    break;

                }
            }
            Console.WriteLine("Equal ?? :" + a);
        }
    }
}
     
 


