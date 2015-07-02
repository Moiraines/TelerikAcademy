namespace _01.SchoolClasses
{
    using System;
    public class Student : Human
    {
        private long classNumber;

        public Student(string firstName, string lastName, long classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public long ClassNumber
        {
            get { return this.classNumber; }
            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Class number must be > 0");
                }
                this.classNumber = value; 
            }
        }

        public override void MakeComment(string text)
        {
            this.ITextBlock = text;
        }        
    }
}
