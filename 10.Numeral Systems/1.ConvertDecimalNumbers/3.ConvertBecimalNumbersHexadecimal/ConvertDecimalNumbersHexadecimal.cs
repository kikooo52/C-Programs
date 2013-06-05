using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ConvertBecimalNumbersHexadecimal
{
    class ConvertDecimalNumbersHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter desimal number:");
            List<string> hexnum = new List<string>();
            int num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                switch (num % 16)
                {
                    case 10: hexnum.Add("A"); break;
                    case 11: hexnum.Add("B"); break;
                    case 12: hexnum.Add("C"); break;
                    case 13: hexnum.Add("D"); break;
                    case 14: hexnum.Add("E"); break;
                    case 15: hexnum.Add("F"); break;
                    default:                    
                        hexnum.Add(Convert.ToString(num % 16));
                        break;
                }
                num = num / 16;
            }
            for (int i = hexnum.Count-1; i >= 0; i--)
            {
                Console.Write(hexnum[i]);
            }
            Console.WriteLine();
        }
    }
}
