using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ConvertHexadecimalNumbersToBinary
{
    class ConvertHexadecimalNumbersToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number:");
            string hexnumber = Console.ReadLine();
            List<string> binarinum = ConvertBinary(hexnumber);
            PrintBinary(hexnumber, binarinum);
        }

        private static void PrintBinary(string hexnumber, List<string> binarinum)
        {
            for (int i = hexnumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binarinum[i]);
            }
            Console.WriteLine();
        }

        private static List<string> ConvertBinary(string hexnumber)
        {
            List<string> binarinum = new List<string>();
            for (int i = 0; i < hexnumber.Length; i++)
            {
                switch (hexnumber[hexnumber.Length - i - 1])
                {
                    case '1': binarinum.Add("0001"); break;
                    case '2': binarinum.Add("0010"); break;
                    case '3': binarinum.Add("0011"); break;
                    case '4': binarinum.Add("0100"); break;
                    case '5': binarinum.Add("0101"); break;
                    case '6': binarinum.Add("0110"); break;
                    case '7': binarinum.Add("0111"); break;
                    case '8': binarinum.Add("1000"); break;
                    case '9': binarinum.Add("1001"); break;
                    case 'A': binarinum.Add("1010"); break;
                    case 'B': binarinum.Add("1011"); break;
                    case 'C': binarinum.Add("1100"); break;
                    case 'D': binarinum.Add("1101"); break;
                    case 'E': binarinum.Add("1110"); break;
                    case 'F': binarinum.Add("1111"); break;
                    default: binarinum.Add("0000");
                        break;
                }

            }
            return binarinum;
        }
    }
}
