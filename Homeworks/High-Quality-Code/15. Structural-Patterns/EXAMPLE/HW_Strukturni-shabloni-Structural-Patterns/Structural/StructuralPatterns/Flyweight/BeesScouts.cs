namespace Flyweight
{
    using System;

    public class BeesScouts : Bee
    {
        public BeesScouts()
        {
            this.Job = "scout";
            this.Width = 100;
            this.Height = 50;
        }

        public override void Display(int years)
        {
            Console.WriteLine("{0} (years {1})", this.Job, years);
        }
    }
}
