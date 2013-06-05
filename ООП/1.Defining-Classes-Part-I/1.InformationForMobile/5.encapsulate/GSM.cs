using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.encapsulate
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

            if (Owner.Length < 20 && Owner.Length > 0)
            {
                this.owner = Owner;
            }
            else
            {
                throw new ArgumentException("The value must to be less of 20, and bigger of 0");
            }
            if (Manufacturer.Length < 10 && Manufacturer.Length > 0)
            {
                this.manufacturer = Manufacturer;
            }
            else
            {
                throw new ArgumentException("The value must to be less of 10, and bigger of 0");
            }
            this.battery = new Battery();
            this.display = new Display();

        }


        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The value is null, enter bigger");
                }
                if (value.Length > 10)
                {
                    throw new ArgumentException("The value must to be less of 10");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value not must to be less of null");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return "GSM Info: Name:" + owner + ", Model:" + model + ", Manufacturer: " + manufacturer + ", Price: " + price + ", Battery Model: " + Battery.BatteryModel + ",Hours idle:" + Battery.HoursIdle + " BatteryType: " + BatteryType.NiCd;

        }
    }
}