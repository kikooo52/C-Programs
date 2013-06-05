using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadsAYearChecksWhether
{
    class ReadsAYearChecksWhether
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Years to check:");
            int years = int.Parse(Console.ReadLine());
            bool isleap = DateTime.IsLeapYear(years);
            Console.WriteLine("Is leap? :"+ isleap);
        }
    }
}
