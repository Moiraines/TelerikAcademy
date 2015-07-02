
namespace AnimalHierarchy
{
    using System;
    public abstract class Animal : ISound
    {
        private string name;
        private double age;

        protected Animal(string name, double age)
            : this(name, age, new Gender())
        {

        }

        protected Animal(string name, double age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
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

        public double Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0 || value > byte.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Age should be > 0 and < 128");
                }
                this.age = value;
            }
        }

        public Gender Sex { get; private set; }

        public abstract string MakeSound();
    }
}
