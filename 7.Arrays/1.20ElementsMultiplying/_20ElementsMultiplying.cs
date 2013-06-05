using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _20ElementsMultiplying
{
    static void Main(string[] args)
    {
        int[] elements = new int[20];
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = (i); 
            Console.WriteLine(elements[i] * 5);
        }
    }
}

