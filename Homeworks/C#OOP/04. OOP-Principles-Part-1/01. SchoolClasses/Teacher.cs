
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Teacher : Human
    {
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
            : base(firstName, lastName)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            private set 
            {
                if (value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException("Disciplines cannot be 0");
                }
                this.disciplines = value; 
            }
        }

        public override void MakeComment(string text)
        {
            this.ITextBlock = text;
        }
    }
}
