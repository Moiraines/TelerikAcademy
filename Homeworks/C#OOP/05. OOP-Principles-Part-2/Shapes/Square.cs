namespace Shapes
{
    public class Square : Shape
    {
        public Square(double width)
            : base(width)
        {

        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Width;
            return surface;
        }
    }
}
