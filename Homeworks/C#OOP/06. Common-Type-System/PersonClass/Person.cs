
namespace PersonClass
{
    using System;
    using System.Linq;
    public class Person
    {

        public Person(string name)
            : this(name, null)
        {

        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int? Age { get; private set; }

        public override string ToString()
        {
            string age;
            if (this.Age == null)
            {
                age = "<Unspecified>";
            }
            else
            {
                age = this.Age.ToString();
            }
            return String.Format("Student(Name: {0}, Age: {1})",this.Name, age);
        }

    }
}
