using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string OtherInfo { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Student(string firstName, string lastName, string orderInfo, string birthDate)
        {
            this.BirthDate = DateTime.Parse(birthDate);
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = orderInfo;
        }

        public bool IsOlderThan(Student firstStudent, Student secondStudent)
        {
            DateTime firstDate = firstStudent.BirthDate;
            DateTime secondDate = secondStudent.BirthDate;

            bool isOlder = firstDate > secondDate;
            return isOlder;
        }
    }
}
