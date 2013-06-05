using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
   public abstract class Accaunt
    {
        private decimal balans;
        private decimal interestRate;
        public Customer customer {get; set;}

        public Accaunt(Customer Customer, decimal balans, decimal interestRate)
        {
            this.Balans = balans;
            this.customer = Customer;
            this.InterestRate = interestRate;
        }

        public decimal Balans
        {
            get { return this.balans; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must to be bigger than 0");
                }
                this.balans = value;
            }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must to be bigger than 0");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal InterestAmaunt(decimal NumberOfMonths)
        {
            return NumberOfMonths * interestRate;
        }
    }
}
