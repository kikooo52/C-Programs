using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FindsStudents
{
    class studentInfo
    {
        static void Main(string[] args)
        {

            var student = new []
        { 
          new  { firstName="Kiril", lastName="Tanushev" }, 
          new  { firstName="Georgi", lastName="Georgiev" },
          new  { firstName="Stamen", lastName="Amneow" },
          new  { firstName="Angel", lastName="Kostadinow" }
        };

            var firstBeforeLast =
                from name in student
                where name.firstName.CompareTo(name.lastName) < 0
                select name;

            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine(item);
            }
        }
    }
}
