namespace Decorator
{
    using System;

    internal class DressUp : WomanDecorator
    {
        private readonly int numberOfItems;

        public DressUp(Outfit outfit, int numberOfItems)
            : base(outfit)
        {
            this.numberOfItems = numberOfItems;
        }

        public override void Wearing()
        {
            base.Wearing();
            Console.WriteLine("Number of wearing Items: " + this.numberOfItems);
        }
    }
}
