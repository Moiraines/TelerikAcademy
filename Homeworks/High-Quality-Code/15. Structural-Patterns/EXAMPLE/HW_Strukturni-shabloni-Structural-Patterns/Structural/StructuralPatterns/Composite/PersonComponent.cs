namespace Composite
{
    public abstract class PersonComponent
    {
        protected PersonComponent(string name, string rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

        protected string Name { get; private set; }
        
        protected string Rank { get; private set; }

        public abstract void Display();
    }
}
