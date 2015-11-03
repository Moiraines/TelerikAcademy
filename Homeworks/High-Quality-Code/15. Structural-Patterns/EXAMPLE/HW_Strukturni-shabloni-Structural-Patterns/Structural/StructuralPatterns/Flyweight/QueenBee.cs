namespace Flyweight
{
    using System;

    public class QueenBee : Bee
    {
        public QueenBee()
        {
            this.Job = "queen";
            this.Width = 200;
            this.Height = 70;
        }

        public override void Display(int years)
        {
            Console.WriteLine("{0} (years {1})", this.Job, years);
        }
    }
}
