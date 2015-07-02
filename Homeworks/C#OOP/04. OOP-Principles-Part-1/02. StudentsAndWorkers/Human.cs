namespace _02.StudentsAndWorkers
{
    using System;
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("First name should be more then 1 symbol");
                }

                this.firstName = value;
            } 
        }

        public string LastName 
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Last name should be more then 1 symbol");
                }

                this.lastName = value;
            } 
        }
    }
}
