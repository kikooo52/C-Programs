using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConvertBinaryNumbers
{
    class ConvertBinaryNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary numbers :");
            string binarynum = Convert.ToString(Console.ReadLine());
            int decimalnumber = 0;
            for (int i = 0; i < binarynum.Length; i++)
            {
                if (binarynum[binarynum.Length - i - 1] == '1')
                {
                    decimalnumber += (int)Math.Pow(2, i);   
                }           
            }
            Console.WriteLine(binarynum + ":" + decimalnumber);
        }
    }
}