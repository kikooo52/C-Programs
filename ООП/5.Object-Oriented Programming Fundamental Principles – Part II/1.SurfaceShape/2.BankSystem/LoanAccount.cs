using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
    class LoanAccount : Accaunt, IDepositable 
    {
        public LoanAccount(Customer customer, decimal Balans, decimal InterestRate)
          : base(customer, Balans, InterestRate)
      { }


        decimal IDepositable.DepositMoney(decimal amount)
        {
            return this.Balans = Balans + amount;
        }

        public override decimal InterestAmaunt(decimal NumberOfMonths)
        {
            if (customer is Individual)
            {
                if (NumberOfMonths < 3)
                {
                    return 0; 
                }
                else
                {
                    return this.InterestRate * (NumberOfMonths - 3);
                }
            }
            else
            {
                if (NumberOfMonths < 2)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (NumberOfMonths - 2);
                }
            }
        }


       
    }
}
