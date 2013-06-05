using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gsmCall
{
    class Program
    {
        static void Main(string[] args)
        {
              DateTime date1 = DateTime.Now;
  
            GSM newGsmCall = new GSM();
            newGsmCall.CallHistory.Add(new Call(date1, 0878547866, 180, "Kiril"));     //adding calls from the calls history
            newGsmCall.CallHistory.Add(new Call(date1, 0878256567, 120, "Tosho"));
            newGsmCall.CallHistory.Add(new Call(date1, 0898321455, 120, "Ogi"));
            newGsmCall.CallHistory.Add(new Call(date1, 0878547866, 240, "Kiril"));

            foreach (Call call in newGsmCall.CallHistory)
            {
                Console.WriteLine("Name: " + call.Name);
                Console.WriteLine("Number: " + call.Number);
                Console.WriteLine("Date: " + call.Date);
                Console.WriteLine("Duration in seconds: " + call.Duration);
                Console.WriteLine();
            }

             //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("Total price: " + newGsmCall.CalculateTotalPrice(0.37m) + "$");      

            newGsmCall.RemoveCallMaxValue();       // Remove the longest call from the history  and calculate the total price again.
            Console.WriteLine("Total price: " + newGsmCall.CalculateTotalPrice(0.37m) + "$");      


            newGsmCall.ClearCallHistory(); //method to clear the call history.

            GSM newGsm = new GSM("Gogo", "Samsung", "S 222", 32323);
            Battery bateryInfo = new Battery("GG 33", 222, BatteryTypes.LiPol);
            Display Newdisplay = new Display("112x23",232323);
            Console.WriteLine(newGsm.ToString());
        }
    }
}
