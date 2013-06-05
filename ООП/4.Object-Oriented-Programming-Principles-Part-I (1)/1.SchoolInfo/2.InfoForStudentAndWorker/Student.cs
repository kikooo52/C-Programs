using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InfoForStudentAndWorker
{
   public class Student : Human, IComparable<Student>
    {
        public int grade {get ; protected set;}
        private List<Student> students = new List<Student>();
        

        public Student(string FirstName, string LastName, int Garde)
            : base(FirstName, LastName)
        {
            this.grade = Garde;
        }

        public int CompareTo(Student other)
        {
            return this.grade.CompareTo(other.grade);
        }


     
    }
}
