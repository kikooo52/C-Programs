using System;
using System.Collections.Generic;

namespace _5.RemoveNegativeNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                -111, 2, -22, 3, -2, 4, 5,-7, 8
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
