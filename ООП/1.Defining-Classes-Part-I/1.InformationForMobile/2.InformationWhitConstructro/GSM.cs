using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationWhitConstructor
{

    class GSM
    {
        public Battery Battery = new Battery();
        public Display Display = new Display();

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        public GSM(string Owner, string Manufacturer)
        {
            this.owner = Owner;
            this.manufacturer = Manufacturer;

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
    }
}