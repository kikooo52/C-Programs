using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolInfo
{
    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines = new List<Discipline>();
        private Discipline discipline = new Discipline();
        private string comment;

        public Teacher(string FirstName, string LastName)
            : base(FirstName, LastName)
        {
        }

        public School School
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Discipline Discipline
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void AddDiscipline(Discipline disciline)
        {
            this.disciplines.Add(discipline);
        }

        public void AddComment(string comment)
        {
            this.comment = comment;
        }
    }
}
