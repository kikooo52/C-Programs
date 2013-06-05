using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortTheStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentInfo = new[]
        { 
          new  { firstName="Kiril", lastName="Tanushev", Age = 29 }, 
          new  { firstName="Georgi", lastName="Georgiev", Age = 23 },
          new  { firstName="Angel", lastName="Amneow", Age = 18 },
          new  { firstName="Angel", lastName="Kostadinow", Age = 24 },
           new  { firstName="Foto", lastName="Hoidutin", Age = 21 },
            new  { firstName="GOsho", lastName="Reeretov", Age = 32 }

        };
            var studentsSort =
             from student in studentInfo
             orderby student.firstName, student.lastName        // LINQ
             select student;

            foreach (var item in studentsSort)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var studentsSortLambda = studentInfo.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);  //Lambda

            foreach (var item in studentsSortLambda)
            {
                Console.WriteLine(item);
            }
        }
    }
}
