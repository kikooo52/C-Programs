using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseInts
{
    class Program
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            while (true)
            {
                string number = Console.ReadLine();

                if (number == string.Empty)
                {
                    break;
                }

                numbers.Push(int.Parse(number));
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
