using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
  public abstract class Customer
    {
        private string firstName;
        private string lastName;
        private int iD;

        public Customer(string FirstName, string LastName, int ID)
        {
            this.iD = ID;
            this.firstName = FirstName;
            this.lastName = LastName;
        }
    }
}
