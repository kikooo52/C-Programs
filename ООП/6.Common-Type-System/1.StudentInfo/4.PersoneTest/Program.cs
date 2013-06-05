using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersoneTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Angel", 33);
            Person somePerson = new Person("Lubo", 13);
            Person newPersone = new Person("Petyr", null);
            Person men = new Person("Roki");
            Console.WriteLine(person.ToString());
            Console.WriteLine(somePerson.ToString());
            Console.WriteLine(newPersone.ToString());
            Console.WriteLine(men.ToString());

        }
    }
}
