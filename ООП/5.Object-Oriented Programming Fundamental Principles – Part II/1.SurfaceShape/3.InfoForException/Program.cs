using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InfoForException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
             SearchData();
             SearchNumber();
          
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void SearchNumber()
        {
         
                int max = 100;
                int min = 0;
                Console.WriteLine("Enter number in the range 1 - 100");
                int num = int.Parse(Console.ReadLine());
                if (min > 0 && num < max)
                {
                    Console.WriteLine("The number:{0} is in range", num);
                }
                else
                {
                    throw new InvalidRangeException<int>(max, min, num);
                }
        }
        private static void SearchData()
        {           
                DateTime min = new DateTime(1980, 1, 1);
                DateTime max = new DateTime(2013, 12, 31);
                Console.WriteLine("Enter Data in the range[1.1.1980 … 31.12.2013]");
                DateTime data = DateTime.Parse(Console.ReadLine());
                if (data > min && data < max)
                {
                    Console.WriteLine("The data: {0} is in range", data);
                }
                else
                {
                    throw new InvalidRangeException<DateTime>(max, min, data);
                }
                Console.WriteLine();
        }
    }
}
