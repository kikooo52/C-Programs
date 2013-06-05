using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindsLongestSubsequence
{
   public class Subsequence
    {
       static void Main()
       {
           
       }
        public static List<int> FindSubsequence(List<int> newList)
        {
            int number = 0;
            int len = 1;
            int maxLen = 1;

            List<int> newSequence = new List<int>();

            for (int i = 1; i < newList.Count; i++)
            {
                if (newList[i - 1] == newList[i])
                {
                    len++;
                    if (len >= maxLen)
                    {
                        maxLen = len;
                        number = i;
                    }
                }
                else
                {
                    len = 1;
                }
            }

            for (; maxLen > 0; maxLen--)
            {
                int j = number - maxLen;

                newSequence.Add(newList[j + 1]);
            }

            return newSequence;
        }
    }
}
