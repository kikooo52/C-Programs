using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolInfo
{
    public class School : ICommentable
    {
   
        private List<Students> classSchool = new List<Students>();
        private List<Teacher> teachers = new List<Teacher>();
        private int Id;
        private string comment;

        public School()
        {     
        }

        public List<Teacher> ClassTeacher
        {
            get { return teachers; }
            protected set { this.teachers = value; }
        }

        public List<Students> Student
        {
            get { return classSchool; }
            protected set { this.classSchool = value; }
        }

        public int ID
        {
            get { return this.Id; }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The ID must to be a positive number!");
                }
                this.Id = value;
            }
        }

        public void AddComment(string comment)
        {
            this.comment = comment;
        }
    }
}
