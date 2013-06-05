using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKindInfo
{
   public class Animal
    {
        public int age { get; set; }
        public string name { get; set; }
        public char sex { get; set; }

        public Animal(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public static double AverageAge(Animal[] someAnimal)
        {
          // return someAnimal.Average(p => p.age);

           int count = 0;
           double sum = 0;
           double average;
           foreach (var item in someAnimal)
           {
               count++;
               sum += item.age;
           }
           average = sum / count;
           return average;
         
        }
      
    }
}
