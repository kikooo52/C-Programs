using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindsStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentInfo = new[]
        { 
          new  { firstName="Kiril", lastName="Tanushev", Age = 29 }, 
          new  { firstName="Georgi", lastName="Georgiev", Age = 23 },
          new  { firstName="Stamen", lastName="Amneow", Age = 18 },
          new  { firstName="Angel", lastName="Kostadinow", Age = 24 }
        };

            var studentsAge  =
              from student in studentInfo
              where student.Age >= 18 && student.Age <= 24
              select student;

               
            foreach (var item in studentsAge)
            {
                Console.WriteLine(item);  
            }
        }
    }
}
