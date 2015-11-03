namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class SchoolMember : PersonComponent
    {
        private readonly List<PersonComponent> schoolMembers;

        public SchoolMember(string name, string rank)
            : base(name, rank)
        {
            this.schoolMembers = new List<PersonComponent>();
        }

        public void Add(PersonComponent person)
        {
            this.schoolMembers.Add(person);
        }

        public void Remove(PersonComponent person)
        {
            this.schoolMembers.Remove(person);
        }

        public override void Display()
        {
            Console.WriteLine("----------------"+this.Rank+"---------------");
            Console.WriteLine(this.Name + " " + this.Rank);
            Console.WriteLine();
            foreach (var person in this.schoolMembers)
            {
                person.Display();
            }
        }
    }
}
