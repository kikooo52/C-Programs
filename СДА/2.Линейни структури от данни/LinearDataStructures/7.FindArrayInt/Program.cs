using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.FindArrayInt
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


            var keyList = listItem.Keys.ToList();
            keyList.Sort();

            foreach (var item in keyList)
            {
                Console.WriteLine("{0}= {1}",item, listItem[item]);
            }
        }
    }
}
