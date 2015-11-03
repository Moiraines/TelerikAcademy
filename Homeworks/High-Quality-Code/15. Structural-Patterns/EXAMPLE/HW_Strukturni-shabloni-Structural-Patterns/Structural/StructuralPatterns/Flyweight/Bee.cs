namespace Flyweight
{
    public abstract class Bee
    {
        protected string Job { get; set; }

        protected int Width { get; set; }

        protected int Height { get; set; }

        public abstract void Display(int size);
    }
}
