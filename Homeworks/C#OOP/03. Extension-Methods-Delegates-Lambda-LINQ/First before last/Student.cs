namespace First_before_last
{
    using System;
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name cannot be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name cannot be empty");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0 || value > 150)
                {
                    throw new ArgumentException("Age must be between 1 and 150");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, age {2}", this.firstName, this.lastName, this.age);
        }
    }
}
