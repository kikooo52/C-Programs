using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKindInfo
{
  public class Kitten : Cat, ISound
    {
      public Kitten(string name, int age)
            : base(name, age, 'F')
        { }
        public void SomeSound()
        {
            Console.WriteLine( "MRRRRRRRRRRRRRRRRRR");
        }
    }
}
