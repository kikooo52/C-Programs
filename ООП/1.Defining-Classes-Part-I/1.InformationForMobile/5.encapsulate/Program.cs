using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.encapsulate
{
    class Program
    {
        static void Main(string[] args)
        {

            GSM newGsm = new GSM("Kiril", "Nokia");

            Console.WriteLine("Enter name on model:");
            newGsm.Model = Console.ReadLine();

            Console.WriteLine("Enter name on Price:");
            newGsm.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter battery model:");
            newGsm.Battery.BatteryModel = Console.ReadLine();

            Console.WriteLine("Enter hours idle:");
            newGsm.Battery.HoursIdle = int.Parse(Console.ReadLine());

            Console.WriteLine(newGsm.ToString());
          

        }
    }
}
