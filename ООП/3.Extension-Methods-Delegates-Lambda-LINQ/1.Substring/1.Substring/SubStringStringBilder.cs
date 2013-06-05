using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Substring
{
   public static class SubStringStringBilder
    {
        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            StringBuilder subString = new StringBuilder();
            if (index + length <= input.Length)
            {
                int lengthString = index + length;

                for (int i = index; i < lengthString; i++)
                {
                    subString.Append(input[i]);
                }
                return subString;
            }
            else
            {
                throw new ArgumentOutOfRangeException("SubString is our of range!");
            }
        }
    }
}
