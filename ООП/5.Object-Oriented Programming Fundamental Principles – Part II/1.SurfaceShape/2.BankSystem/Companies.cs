using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
    class Companie : Customer
    {

        public Companie(string FirstName, string LastName, int ID)
            : base(FirstName, LastName, ID)
        { }
    }
}
