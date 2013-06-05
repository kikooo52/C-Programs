using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;

namespace ReadsTwoIntegerNumbersNAndK
{
    public class ReadsTwoIntegerNumbersNAndK
    {
        private int[] ElementOfN;
        private int ElementOfK;

        public ReadsTwoIntegerNumbersNAndK(int numberN, int numberK)
        {
            ElementOfN = new int[numberN];
            ElementOfK = numberK;
        }
        public void GenerateNandK()
        {
            int sum = 0;
            int arraylen = ElementOfN.Length;
            Random random = new Random();
            for (int i = 0; i < ElementOfN.Length; i++)
            {
                ElementOfN[i] = random.Next(1, ElementOfK);
            }

            for (int i = 0; i < ElementOfN.Length; i++)
            {
                if (i + ElementOfK > arraylen)
                {
                    break;
                }
            }
            Array.Sort(ElementOfN);
            for (int j = ElementOfN.Length - 1; j >= ElementOfN.Length - ElementOfK; j--)
            {
                sum += ElementOfN[j];
            }
            Console.WriteLine(sum);
        }
    }

}