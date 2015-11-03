namespace Decorator
{
    internal abstract class WomanDecorator : Outfit
    {
        protected WomanDecorator(Outfit outfit)
        {
            this.Outfit = outfit;
        }

        protected Outfit Outfit { get; private set; }

        public override void Wearing()
        {
            this.Outfit.Wearing();
        }
    }
}
