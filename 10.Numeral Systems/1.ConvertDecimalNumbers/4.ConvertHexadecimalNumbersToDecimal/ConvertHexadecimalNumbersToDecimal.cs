using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConvertHexadecimalNumbersToDecimal
{
    class ConvertHexadecimalNumbersToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexnumber = Console.ReadLine();
            int decimalnum = 0;
            int hexdegree = hexnumber.Length -1;
            int sum = 0;
            for (int i = 0; i < hexnumber.Length; i++)
            {
                switch (hexnumber[hexnumber.Length -1-i])
                {
                    case 'A': decimalnum = 10; break;
                    case 'B': decimalnum = 11; break;
                    case 'C': decimalnum = 12; break;
                    case 'D': decimalnum = 13; break;
                    case 'E': decimalnum = 14; break;
                    case 'F': decimalnum = 15; break;
                    default:
                        decimalnum = int.Parse(Convert.ToString(hexnumber[hexnumber.Length - 1 - i]));
                        break;
                }
                decimalnum *= (int)Math.Pow(16, i);
                sum += decimalnum;
            }
            Console.WriteLine("decimal numer:"+sum);
        }
    }
}