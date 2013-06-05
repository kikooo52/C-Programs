using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IPhone4S
{
    public class GSM
    {
        private Battery battery;
        private Display display;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        static GSM iphone = new GSM("Angel","Apple","Iphone4s",999);

        public GSM()
        {
        }

        public GSM(string Owner, string Manufacturer, string Model, decimal Price)
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

            this.model = Model;
            if (Price > 0)
            {             
                this.price = Price;
            }
            else
            {
                throw new ArgumentException("The value not must to be less of null");
            }
            this.battery = new Battery();
            this.display = new Display();

        }


        public static GSM IPhone
        {
            get { return iphone; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
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
            return "GSM Info: Name:" + owner + ", Model:" + model + ", Manufacturer: " + manufacturer + ", Price: " + price + ", Battery Model: " + Battery.BatteryModel + ",Hours idle:" + Battery.HoursIdle + " BatteryType: " + BatteryTypes.NiCd;

        }
    }
}