using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
   public class DepositAccounts : Accaunt, IDepositable, IDrawable
    {
       public DepositAccounts(Customer customer, decimal Balans, decimal InterestRate)
          : base(customer, Balans, InterestRate)
      { }

       public decimal DepositMoney(decimal amount)
       {
           return this.Balans = Balans + amount;
       }

       public decimal DrowMoney(decimal amount)
       {
           return this.Balans = Balans - amount;
       }

       public override decimal InterestAmaunt(decimal NumberOfMonths)
       {
           if (Balans < 1000)
           {
               return 0; 
           }
           else
           {
               return this.InterestRate * NumberOfMonths;
           }
       }
    }
}

