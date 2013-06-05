using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolInfo
{
   public class Discipline
    {
       private string nameOfDiscipline;
       private int numberOfLecturs;
       private int numberOfExercises;

       public Discipline(string NameOfDisciline, int NumberOfLecturs, int NumberOfExercises)
       {
           if (NameOfDisciline != null)
           {
              this.nameOfDiscipline = NameOfDisciline; 
           }
           else
           {
               throw new ArgumentNullException();
           }
           if (NumberOfExercises > 0)
           {
               this.numberOfExercises = NumberOfExercises;
           }
           else
           {
               throw new ArgumentOutOfRangeException("The number of Exercises must be a positive number!");
           }
           if (NumberOfLecturs > 0)
           {
               this.numberOfLecturs = NumberOfLecturs;
           }
           else
           {
               throw new ArgumentOutOfRangeException("The number of lectures must be a positive number!");
           }
       }

       public Discipline()
       {
       }
    }
}
