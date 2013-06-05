using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolInfo
{
   public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string FirstName, string LastName)
        {
            if (FirstName != null)
            {
                this.FirstName = FirstName; 
            }
            else
            {
                throw new ArgumentNullException();
            }

            if (LastName != null)
            {
              this.LastName = LastName;
            }
            else
            {
                throw new ArgumentNullException();
            }
        

        }

    }
}
