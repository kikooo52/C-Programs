using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKindInfo
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, 'M')
        { }
        public void SomeSound()
        {
            Console.WriteLine("MIQQQQQQQQQUUUUUUUUUUUU");
        }
    }
}
