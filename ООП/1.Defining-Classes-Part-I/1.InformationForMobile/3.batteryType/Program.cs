using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.batteryType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name on owner:");
            string owner = Console.ReadLine();

            Console.WriteLine("Enter name on manufacturer:");
            string manufacturer = Console.ReadLine();

            GSM newGsm = new GSM(owner, manufacturer);

            Console.WriteLine("Enter name on model:");
            newGsm.Model = Console.ReadLine();

            Console.WriteLine("Enter name on Price:");
            newGsm.Price = decimal.Parse(Console.ReadLine());

            newGsm.Battery.BatteryType = BatteryType.LiPol;
            Console.WriteLine(newGsm.Battery.BatteryType);

            
           
         


        }
    }
}
