namespace Composite
{
    using System;

    public class Person : PersonComponent
    {
        public Person(string name, string rank)
            : base(name,rank)
        {
        }

        public override void Display()
        {
            Console.WriteLine(this.Name + " " + this.Rank);
        }
    }
}
