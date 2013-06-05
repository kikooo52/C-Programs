using _1.InformationForMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4.overrideTostring
{

    class GSM
    {
        private Battery battery;
        private Display display;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;


        public GSM(string Owner, string Manufacturer)
        {
            this.owner = Owner;
            this.manufacturer = Manufacturer;

            this.battery = new Battery();
            this.display = new Display();

        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public override string ToString()
        {
            return "GSM Info: Name:" + owner + ", Model:" + model + ", Manufacturer: " + manufacturer + ", Price: " + price + ", Battery Model: " + Battery.BatteryModel + ",Hours idle:" + Battery.HoursIdle + " BatteryType: " + BatteryType.NiCd;

        }
    }
}