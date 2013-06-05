using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.IntIncreasingOrder
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string number = Console.ReadLine();

                if (number == string.Empty)
                {
                    break;
                }

                numbers.Add(int.Parse(number));
            }

            foreach (var num in numbers.OrderBy(x => x))
            {
                Console.Write(num + ",");
            }
            

        }
    }
}
