using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InfoForStudentAndWorker
{
 public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human()
        { }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
      


        public override string ToString()
        {
            return firstName + " " + lastName;
            
        }    
    }
}
