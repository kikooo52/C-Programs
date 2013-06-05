using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FunctionThatReadsRaluesOfString
{
    class FunctionThatReadsRaluesOfString
    {
        static void Main(string[] args)
        {
            string input = "43 68 9 23 318";
            input = input.Trim();
            int sum = 0;
            string[] strNums = input.Split(' ');
            for (int i = 0; i < strNums.Length; i++)
            {
                sum = sum + int.Parse(strNums[i].Trim());
            }
            Console.WriteLine(sum);
        }
    }
}
    

