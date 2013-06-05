using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomArray = new int[500];

            for (int i = 0; i < 500 - 1; i++)
            {
                randomArray[i] = random.Next(1, 501);
            }
            var divide =
                from number in randomArray                  // LINQ
                where number % 3 == 0 && number % 7 == 0
                select number;

            foreach (var item in divide)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var divideLambda = randomArray.Where(x => x % 3 == 0 && x % 7 == 0);          //Lambda

            foreach (var item in divideLambda)
            {
                Console.WriteLine(item);
            }


        }
    }
}
