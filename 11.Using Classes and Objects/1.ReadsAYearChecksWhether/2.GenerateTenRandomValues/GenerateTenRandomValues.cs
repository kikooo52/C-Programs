using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GenerateTenRandomValues
{
    class GenerateTenRandomValues
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 1; i < array.Length+1; i++)
            {
                Console.WriteLine("{0}:{1};",i,array[i-1] = random.Next(100, 201));
            }
            Console.WriteLine();
        }
    }
}
