using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.RemoveOddNumber
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
            };

            Dictionary<int, int> listItem = new Dictionary<int, int>();

            foreach (var item in list)
            {
                if (!listItem.Keys.Contains(item))
                {
                    listItem.Add(item, 1);
                }
                else
                {
                    listItem[item]++;
                }
            }

            foreach (KeyValuePair<int, int> pair in listItem)
            {
                if (pair.Value % 2 == 0)
                {
                    list.RemoveAll(x => x == pair.Key);
                }
            }

            foreach (var item in list)
            {
                Console.Write(item +", ");
            }
        }  
    }
}
