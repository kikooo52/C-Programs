using _1.InformationForMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class GSM
    {
        public Battery Battery = new Battery();
        public Display Display = new Display();

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        public GSM()
        {
            
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

     
    }
