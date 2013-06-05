using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKindInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs =
            {
                new Dog("Parcho", 2, 'M'),
                new Dog("WhiteTooth", 5, 'M'),
                new Dog("Barkli",3, 'F') 
            };

            Frog[] frogs =
            {       
                new Frog("Kfako", 2, 'M'),
                new Frog("Djambo", 1, 'F'),
                new Frog("Kyrmit",1, 'F') 
            };
           

            Kitten[] kittens = 
            {
                new Kitten("Pisanka", 2),
                new Kitten("Muca", 2),
                new Kitten("Titi",1) 
            };

            Tomcat[] tomcats = 
            {
                new Tomcat("Kotio", 2),
                new Tomcat("Pesho", 1),
                new Tomcat("Myrlio",5) 
            };



            foreach (var item in tomcats)
            {
                Console.Write("Name:" + item.name + ", Age:" + item.age + ", Sex:" + item.sex+" : ");
                item.SomeSound();
            }

            Console.WriteLine();

            foreach (var item in frogs)
            {
                Console.Write("Name:" + item.name + ", Age:" + item.age + ", Sex:" + item.sex+" : ");
                item.SomeSound();
            }
            Console.WriteLine();
            foreach (var item in kittens)
            {
                Console.Write("Name:" + item.name + ", Age:" + item.age + ", Sex:" + item.sex+" : ");
                item.SomeSound();
            }
            Console.WriteLine();
            foreach (var item in dogs)
            {
                Console.Write("Name:" + item.name + ", Age:" + item.age + ", Sex:" + item.sex+" : ");
                item.SomeSound();
                
                
            }

            Console.WriteLine();

            Console.WriteLine("Average age on tomcats are:{0}", Animal.AverageAge(tomcats));
            Console.WriteLine("Average age on kittens are:{0}", Animal.AverageAge(kittens));
            Console.WriteLine("Average age on dogs are:{0}", Animal.AverageAge(dogs));
            Console.WriteLine("Average age on frogs are:{0}", Animal.AverageAge(frogs));


        }
    }
}
