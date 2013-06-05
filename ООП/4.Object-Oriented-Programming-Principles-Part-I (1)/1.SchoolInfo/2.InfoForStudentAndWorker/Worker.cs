using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InfoForStudentAndWorker
{
   public class Worker : Human, IComparable<Worker>
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string FirstName, string LastName,decimal weekSalary,int workHoursPerDay)
            : base(FirstName, LastName)            
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            moneyPerHour = weekSalary / workHoursPerDay / 5;
            return moneyPerHour;
        }

        public int CompareTo(Worker other)
        {
            return this.MoneyPerHour().CompareTo(other.MoneyPerHour());
        }
    }
}
