using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentInfo
{
    public enum University
    { NBU, SU, UNSS, VIAS }

    public enum Specialty
    { Law, Business, Mathematic, Telecomunications, SSS }

    public enum Faculty
    { Telecomunications, Business, Law, StructuralEngineering, FacultyOfGeodesy }

    public class Student : ICloneable, IComparable<Student>
    {
        private string name;
        private string middle;
        private string lastName;
        private int ssn;
        private string permanentAddress;
        private int mibilePhone;
        private string email;
        private int course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student()
        { }

        public Student(string name, string middle, string lastName, int ssn, string permanentAddress, int mibilePhone, string email, int course, StudentInfo.University university, StudentInfo.Specialty specialty, StudentInfo.Faculty faculty)
        {
            this.Name = name;
            this.Middle = middle;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MibilePhone = mibilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Specialty = specialty;
            this.Faculty = faculty;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public string Middle
        {
            get { return this.middle; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.middle = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }

        public int SSN
        {
            get { return this.ssn; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.permanentAddress = value;
            }
        }

        public int MibilePhone
        {
            get { return this.mibilePhone; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException();
                }
                this.mibilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.email = value;
            }
        }
        public int Course
        {
            get { return this.course; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException();
                }
                this.course = value;
            }
        }

        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public override bool Equals(object param)
        {

            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.Name, student.Name))
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ SSN.GetHashCode() & Email.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2} \nSSN: {3} \nAddress: {4} \nMobile phone: {5} \nSpecialty: {6} \n" +
                "University: {7}", name, middle, lastName, ssn, permanentAddress, mibilePhone, specialty, university);

        }

    
    

        public object Clone()
        {
            return new Student(
                string.Copy(this.Name),
                string.Copy(this.Middle),
                string.Copy(this.LastName),
                this.SSN,
                string.Copy(this.PermanentAddress),
                this.mibilePhone,
                string.Copy(this.Email),
                this.Course,
                this.University,
                this.Specialty,
                this.Faculty
                ); 
        }

        public int CompareTo(Student other)
        {
         
            if (this.Name != other.Name)
            {
               return(this.Name.CompareTo(other.Name));
            }

            if (this.Middle != other.Middle)
            {
                return (this.Middle.CompareTo(other.Middle));
            }

            if (this.LastName != other.LastName)
            {
                return (this.LastName.CompareTo(other.LastName));
            }
            if (this.SSN != other.SSN)
            {
                return (this.SSN.CompareTo(other.SSN));
            }
            return 0;
        }

       
    }
}
