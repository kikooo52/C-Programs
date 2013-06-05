using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersoneTest
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string Name, int? Age = null)
        {       
            this.name = Name;                    
            this.age = Age; 
        }

        public override string ToString()
        {
            return string.Format("Name: {0} \nAge:{1}", this.name, this.age != null ? this.age.ToString() : "age not specified ");
        }
        
    }
}
