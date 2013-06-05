using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WhichDayOfTheWeekIsToday
{
    class WhichDayOfTheWeekIsToday
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("This is the day which the Lord has made; we will be full of joy and delight in it: "+ now.DayOfWeek);
        }
    }
}
