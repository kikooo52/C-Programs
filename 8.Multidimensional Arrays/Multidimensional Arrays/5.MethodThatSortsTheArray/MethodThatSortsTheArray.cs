using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MethodThatSortsTheArray
{
    static void Main(string[] args)
    {
        string[] array = { "aaa", "aa", "aaaa", "aaaaaa", "as","assd","er"};

        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (var element in array)
        {
            Console.Write(element+",");
        }
    }
}

