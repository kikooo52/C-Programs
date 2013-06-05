using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InformationForMobile
{
    static void Main(string[] args)
    {
        GSM informationForGsm = new GSM();

        Console.WriteLine("Enter name on owner:");
        informationForGsm.Owner = Console.ReadLine();

        Console.WriteLine("Enter name on model:");
        informationForGsm.Model = Console.ReadLine();

        Console.WriteLine("Enter name on price:");
        informationForGsm.Price =decimal.Parse( Console.ReadLine());

        Console.WriteLine("Enter name on manufacturer:");
        informationForGsm.Manufacturer = Console.ReadLine();

        Console.WriteLine("Name model of Batery:");
        informationForGsm.Battery.BatteryModel = Console.ReadLine();

        Console.WriteLine("How time is batery limit?");
        informationForGsm.Battery.HoursIdle = int.Parse(Console.ReadLine());

        Console.WriteLine("Size of display:");
        informationForGsm.Display.Size = Console.ReadLine();

        Console.WriteLine("Number of coclor on display:");
        informationForGsm.Display.NumberOfColors = Console.ReadLine();


        Console.WriteLine("Owner:{0},\nModer:{1},\nPrice:{2},\nManufacturer:{3},\nBatery:{4},\nDisplay:{5},\nSize of display:{6}"
            , informationForGsm.Owner, informationForGsm.Model, informationForGsm.Price, informationForGsm.Manufacturer, informationForGsm.Battery.BatteryModel,informationForGsm.Battery.HoursIdle, informationForGsm.Display.NumberOfColors,informationForGsm.Display.Size);
    }
}

