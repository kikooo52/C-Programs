using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student someStudent = new Student
              (
             "Kiril",
            "Stoqnov",
            "Tanushev",
            123456789,
             "Kavrakirowo",
             0897666222,
            "kikooo52@abv.bg",
            3,
             University.NBU,
             Specialty.Telecomunications,
             Faculty.Telecomunications);

  
            Student newStudent = new Student
                (
             "Todor",
            "Stoqnov",
            "Tanushev",
            123456734,
             "Kavrakirowo",
             0897662543,
            "ekikooo52@abv.bg",
            3,
            University.VIAS,
            Specialty.SSS,
            Faculty.Telecomunications);


            Console.WriteLine(someStudent);
            Console.WriteLine();

            Student cloneStudent = (Student)newStudent.Clone();
            Console.WriteLine(cloneStudent);
            Console.WriteLine();

            Console.WriteLine(newStudent);
            Console.WriteLine();
            cloneStudent.Name = "Beti";
            cloneStudent.LastName = "Gorov";
            cloneStudent.Middle = "Terow";
            cloneStudent.PermanentAddress = "Chorichene";
            cloneStudent.MibilePhone = 0897662588;

            Console.WriteLine(cloneStudent);
            Console.WriteLine();
            Console.WriteLine(newStudent);
            Console.WriteLine();

            Console.WriteLine(newStudent.GetHashCode());
            Console.WriteLine(someStudent.GetHashCode());

            Console.WriteLine();
            Console.WriteLine(newStudent.CompareTo(someStudent));
            Console.WriteLine(cloneStudent.CompareTo(newStudent));

            cloneStudent = (Student)someStudent.Clone();
            Console.WriteLine(cloneStudent.CompareTo(someStudent));
            Console.WriteLine(someStudent.Equals(cloneStudent));
            Console.WriteLine(someStudent == cloneStudent);

        }
    }
}
