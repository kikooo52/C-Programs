using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WorkdaysBetweenTodayAndGivenDate
{
    class WorkdaysBetweenTodayAndGivenDate
    {
        private static DateTime[] holidays = 
        {
           new DateTime(2013, 01, 1),
           new DateTime(2013, 03, 03),
           new DateTime(2013, 05, 01),
           new DateTime(2013, 05, 24),
           new DateTime(2013, 09, 06),
           new DateTime(2013, 09, 22),
           new DateTime(2013, 11, 01),
           new DateTime(2013, 12, 24),
           new DateTime(2013, 12, 25),
           new DateTime(2013, 12, 26),
           new DateTime(2013, 12, 31),
        };
        private static DateTime toDay;
        private static int allDays;
        private static DateTime endDay;

        static void Main(string[] args)
        {
            Console.Write("Enter the last day YYYY/MM/DD:");
            endDay = DateTime.Parse(Console.ReadLine());
            counterOfWorkDays();
        }

        private static void counterOfWorkDays()
        {
            toDay = DateTime.Today;
            allDays = (endDay - toDay).Days;
            for (; toDay <= endDay;)
            {
                if (toDay.DayOfWeek == DayOfWeek.Saturday || toDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    allDays--;
                }
                else
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (toDay == holidays[j])
                        {
                            allDays--;
                        }
                    }
                }
                toDay = toDay.AddDays(1);
            }
            Console.WriteLine("All days are :"+allDays);
        }
           
    }
     
}
    

