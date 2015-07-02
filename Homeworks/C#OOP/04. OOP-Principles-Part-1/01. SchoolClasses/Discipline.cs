
namespace _01.SchoolClasses
{
    using System;
    public class Discipline : ITextBlock
    {
        private string name;
        private int lecturesNumber;
        private int exercisesNumber;

        public Discipline(string name, int lecturesNumber, int exercisesNumber)
        {
            this.Name = name;
            this.LecturesNumber = lecturesNumber;
            this.ExercisesNumber = exercisesNumber;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Name should be more then 1 symbol");
                }
                this.name = value;
            }
        }
        
        public int LecturesNumber
        {
            get { return this.lecturesNumber; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Lecture number must be > 0");
                }
                this.lecturesNumber = value;
            }
        }
        
        public int ExercisesNumber
        {
            get { return this.exercisesNumber; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Exercises number must be > 0");
                }
                this.exercisesNumber = value;
            }
        }

        public string ITextBlock { get; set; }

        public void MakeComment(string text)
        {
            this.ITextBlock = text;
        } 
    }
}
