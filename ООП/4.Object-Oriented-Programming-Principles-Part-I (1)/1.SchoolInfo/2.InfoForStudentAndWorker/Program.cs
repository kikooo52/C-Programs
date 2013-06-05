using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InfoForStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            Students.Add(new Student("Boiko", "Borisov", 4));
            Students.Add( new Student("Aoiko", "Tutow", 2));
            Students.Add(new Student("Rosko", "Trenowski", 1));
            Students.Add( new Student("Tanq", "Hristowa", 1));
            Students.Add(new Student("Angel", "Dimcheva", 2));
            Students.Add(new Student("Ogi", "Dimcheva", 3));
            Students.Add(new Student("Vasko", "Borisov", 3));
            Students.Add(new Student("Boiko", "Trenowski", 4));
            Students.Add(new Student("Slavcho", "Gigov", 1));
            Students.Add(new Student("Iliq", "Borisov", 2));

            //Students.Sort();
            //foreach (Student item in Students)
            //{
            //    Console.WriteLine(item.ToString() +" "+item.grade);
            //}
            Console.WriteLine("First name, Last name and grade");
            Console.WriteLine();

            var sortStudsent = Students.OrderBy(x => x.grade);
            foreach (Student item in sortStudsent)
            {
                Console.WriteLine(item.ToString() +": "+item.grade);
            }

            Console.WriteLine();

            List<Worker> Workers = new List<Worker>();

            Workers.Add(new Worker("Gigo", "Gigov",3211,8));
            Workers.Add(new Worker("Aoiko", "Tutow",3432,8));
            Workers.Add(new Worker("Petyr", "Petrow",1234,8));
            Workers.Add(new Worker("Isak", "Levi",555,8));
            Workers.Add(new Worker("Daniel", "Hristow",876,8));
            Workers.Add(new Worker("Dilqna", "Dimcheva", 2333, 8));
            Workers.Add(new Worker("Ogo", "Dimitrow", 1233, 8));
            Workers.Add(new Worker("Simeon", "Trenowski", 2233, 8));
            Workers.Add(new Worker("Oleg", "Dimitrow", 443, 8));
                

            Console.WriteLine("Sort  by money per hour in descending order");
            var sort = Workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (Worker oo in sort)
            {
                Console.WriteLine(oo.ToString() +":  "+ oo.MoneyPerHour()+"$");
            }     
        }
    }
}
