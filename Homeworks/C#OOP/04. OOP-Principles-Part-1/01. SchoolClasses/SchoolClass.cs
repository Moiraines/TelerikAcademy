namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class SchoolClass : ITextBlock
    {
        private string identifier;

        public SchoolClass(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.Identifier = identifier;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string Identifier
        {
            get { return this.identifier; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier cannot be empty!");
                }
                this.identifier = value; 
            }
        }

        public List<Student> Students { get; private set;}
        public List<Teacher> Teachers { get; private set; } 

        public string ITextBlock { get; set; }

        public void MakeComment(string text)
        {
            this.ITextBlock = text;
        }  

    }
}
