namespace Methods
{
    using System;
    using System.Globalization;

    internal class Student
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;

        internal Student(string firstName, string lastName, string dateofBirth, string additionalInfo = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateofBirth;
        }

        public string AdditionalInfo { get; set; }

        internal string FirstName 
        { 
            get 
            {
                return this.firstName;
            }
            
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name must be atleast 3 symbols long");
                }

                this.firstName = value;
            }
        }

        internal string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name must be atleast 3 symbols long");
                }

                this.lastName = value;
            }
        }

        internal string DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                DateTime parsedDate;

                if (!DateTime.TryParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    throw new ArgumentException("DateTime must be exaclty in \"dd.MM.yy\" format");
                }

                this.dateOfBirth = value;
            }
        }

        internal bool IsOlderThan(Student other)
        {
            DateTime currentBirthDate = DateTime.Parse(this.DateOfBirth);
            DateTime otherBirthDate = DateTime.Parse(other.DateOfBirth);
            bool isOlder = currentBirthDate < otherBirthDate;
            return isOlder;
        }
    }
}