using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
  public class MortgageAccounts : Accaunt, IDepositable
    {

      public MortgageAccounts(Customer customer, decimal Balans, decimal InterestRate)
          : base(customer, Balans, InterestRate)
      { }

      public decimal DepositMoney(decimal amount)
      {
          return this.Balans = Balans + amount;
      }

      public override decimal InterestAmaunt(decimal NumberOfMonths)
      {

          if (customer is Companie)
          {
              if (NumberOfMonths <= 12)
              {
                  return this.InterestRate * NumberOfMonths / 2;
              }
              else
              {
                  return (NumberOfMonths - 12) * InterestRate + (NumberOfMonths * InterestRate / 2) ;
              }
          }
         else  
          {
              if (NumberOfMonths < 6)
              {
                  return 0;
              }
              else
              {
                  return this.InterestRate * (NumberOfMonths - 6);
              }
          }
      }

    
    }
}
  
    

