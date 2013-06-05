using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ConvertsAStringToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string sometext = Console.ReadLine();

            foreach (var symbol in sometext)
            {
                Console.WriteLine("\\u{0:X4}", (int)symbol);
            }
        }
    }
}

