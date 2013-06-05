using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolInfo
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Discipline history = new Discipline("History", 12, 3);
            Discipline math = new Discipline("Mathematic", 2, 2);

            Teacher firstTeacher = new Teacher("Rosen", "Plevneliev"); 
            firstTeacher.AddDiscipline(history);
            firstTeacher.AddDiscipline(math);

            School FirstClass = new School();

            FirstClass.Student.Add(new Students("Ivan", "Kostov", 1));
            FirstClass.Student.Add(new Students("Cecka", "Cacheva", 2));
            FirstClass.Student.Add(new Students("Slavi", "Binev", 13));
            FirstClass.Student.Add(new Students("Boiko", "Borisov", 23)); 

            FirstClass.ClassTeacher.Add(firstTeacher);
            FirstClass.ID = 32;

            firstTeacher.AddComment("Rosen is the best Teacher, who a'm seeing!");

            FirstClass.AddComment("I love my class!");
        }
    }
}
