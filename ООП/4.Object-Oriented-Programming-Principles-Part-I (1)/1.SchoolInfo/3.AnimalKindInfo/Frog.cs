using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKindInfo
{
  public class Frog : Animal, ISound
    {
        public Frog(string name, int age, char sex)
            : base(name, age, sex)
        { }

        public void SomeSound()
        {
            Console.WriteLine("KFAAAK-K-K");
        }
    }
}
