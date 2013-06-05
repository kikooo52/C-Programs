using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IPhone4S
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM newGsm = new GSM();
            newGsm = GSM.IPhone;
            Console.WriteLine(newGsm);
            newGsm.Price = decimal.Parse(Console.ReadLine());

        }
    }
}
