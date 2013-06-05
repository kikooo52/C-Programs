using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nineGagNumbers
{
    class nineGagNumbers
    {
        static void Main(string[] args)
        {
            string gagNumber = Console.ReadLine();
            string[] digitsOfNineGag = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-", };
            ulong decimalNum = 0;
            List<string> receivedNumbers = new List<string>();
            StringBuilder NewStringBilder = new StringBuilder(gagNumber);
            while (NewStringBilder.Length > 0)
            {
                for (int i = 0; i < digitsOfNineGag.Length; i++)
                {
                    if (NewStringBilder.ToString().StartsWith(digitsOfNineGag[i]))
                    {
                        decimalNum = decimalNum * 9 + (ulong)i;
                        NewStringBilder.Remove(0, digitsOfNineGag[i].Length);
                    }
                }
            }
            Console.WriteLine(decimalNum);
        }
    }
}
