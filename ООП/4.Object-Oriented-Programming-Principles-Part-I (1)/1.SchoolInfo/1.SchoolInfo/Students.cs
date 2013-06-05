using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolInfo
{
   public class Students :Person, ICommentable
    {
        private int classNumber;
        private string comment;

        public Students(string FirstName, string LastName, int classNumber) : base(FirstName, LastName)
        {
            if (classNumber > 0)
            {
                  this.classNumber = classNumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Class number must to be a positive number!");
            }
         
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

        public void AddComment(string comment)
        {
            this.comment = comment;
        }

    }
}
