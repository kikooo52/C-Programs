using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationWhitConstructor
{
    class Program
    {
        static void Main(string[] args)
        {

            GSM newGsm = new GSM("Kiril", "Apple");

            Console.WriteLine("Enter name on model:");
            newGsm.Model = Console.ReadLine();

            Console.WriteLine("Enter name on Price:");
            newGsm.Price =decimal.Parse( Console.ReadLine());

            Console.WriteLine("Battery model:");
            newGsm.Battery.BatteryModel = Console.ReadLine();
            
            
        }
    }
}
