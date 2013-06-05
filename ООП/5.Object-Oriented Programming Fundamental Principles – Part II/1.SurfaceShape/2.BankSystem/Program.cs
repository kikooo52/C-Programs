using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCoustomer = new Companie("Kiril", "Tanushev", 2322);
           Customer someCoustomer = new Individual("Chocho", "Bochev", 2222);

           object a = 5;
           Object b = a;

            Accaunt[] newAcount = 
            {
                new DepositAccounts(newCoustomer, 5000, 5m),
          
                new DepositAccounts(newCoustomer, 500, 5m),
      
                new MortgageAccounts(newCoustomer, 5000, 5m),
         
                new MortgageAccounts(someCoustomer, 5000, 5m),

                new LoanAccount(newCoustomer, 5000, 5m),

                new LoanAccount(someCoustomer, 5000, 5m)
            };

            foreach (var item in newAcount)
            {
                Console.WriteLine("{0} is: {1}",item.GetType().Name,item.InterestAmaunt(10)+"%");
            }

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


        }
    }
}
               