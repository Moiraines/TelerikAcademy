namespace _01.SchoolClasses
{
    using System;
    using System.Linq;
    public abstract class Human : ITextBlock

    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastname)
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

        public string ITextBlock { get; set; }

        public virtual void MakeComment(string text)
        {
            this.ITextBlock = text;
        } 


    }
}
