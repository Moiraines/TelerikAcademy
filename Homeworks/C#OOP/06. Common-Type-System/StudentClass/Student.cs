namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private uint ssn;
        private string adress;
        private string mobileNumber;
        private string email;
        private byte course;

        public Student(string firstName, string lastName, uint ssn, byte course, Specialty speciality, University univercity, Faculty faculty)
            : this(firstName, string.Empty, lastName, ssn, string.Empty, string.Empty, string.Empty, course, speciality, univercity, faculty)
        {

        }

        public Student(string firstName, string middleName, string lastName, uint ssn, string adress, string mobileNumber, string email, byte course, Specialty speciality, University univercity, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Adress = adress;
            this.MobileNumber = mobileNumber;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.Univercity = univercity;
            this.Faculty = faculty;

        }

        public string FirstName 
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name should not be empty");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name should not be empty");
                }
                this.lastName = value;
            }
        }

        public uint SSN
        {
            get { return this.ssn; }
            private set
            {
                if (value < 100000000 && value > 999999999)
                {
                    throw new ArgumentOutOfRangeException("The Number should contain 9 digits");
                }
                this.ssn = value;
            }
        }

        public string Adress
        {
            get { return this.adress; }
            private set
            {
                this.adress = value;
            }
        }

        public string MobileNumber
        {
            get { return this.mobileNumber; }
            private set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        throw new ArgumentException("Mobile number can contain only digits");
                    }
                }
                this.mobileNumber = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                this.email = value;
            }
        }

        public byte Course
        {
            get { return this.course; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid course number");
                }
                this.course = value;
            }
        }

        public Specialty Speciality { get; private set; }

        public University Univercity { get; private set; }

        public Faculty Faculty { get; private set; }


        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (this.LastName != student.LastName)
            {
                return false;
            }
            
            if (this.Speciality != student.Speciality)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nSSN: {3}\nAdress: {4}\nMobile Phone: {5}\nEmail: {6}\nCourse: {7}\nSpeciality: {8}\nUnivercity: {9}\nFaculty: {10}\n", this.FirstName, this.MiddleName ?? "<unnamed>", this.LastName, this.SSN, this.Adress ?? "<not definied>", this.MobileNumber ?? "<not definied>", this.Email ?? "<not definied>", this.Course, this.Speciality, this.Univercity, this.Faculty);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        //Task 2

        public object Clone()
        {
            Student original = this;
            Student newStudent = new Student(original.FirstName, original.MiddleName, original.LastName, original.SSN, original.Adress, original.MobileNumber, original.Email, original.Course, original.Speciality, original.Univercity, original.Faculty);

            return newStudent as Student;
        }

        //Task 3

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) == 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return this.FirstName.CompareTo(otherStudent.FirstName);
        }
    }
}
