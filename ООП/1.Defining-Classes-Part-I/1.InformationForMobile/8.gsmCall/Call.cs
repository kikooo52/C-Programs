using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gsmCall
{
  public class Call
    {
      private string name;
        private DateTime date;
        private int number;
        private decimal duration;

        public Call() { }

        public Call(DateTime Date, int Number, decimal Duration, string Name)
        {
            this.name = Name;
            this.date = Date;
            this.number = Number;
            this.duration = Duration;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public DateTime Date 
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public decimal Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
