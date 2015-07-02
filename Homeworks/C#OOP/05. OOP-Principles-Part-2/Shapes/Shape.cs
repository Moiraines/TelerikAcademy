namespace Shapes
{
    using System;
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height) 
        {
            this.Width = width;
            this.Height = height;
        }

        //constructor for the square purpose

        public Shape(double width)
        {
            this.Width = width;
        }

        public double Width 
        {
            get { return this.width; } 
            private set
            {
                if (width < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive number");
                }
                this.width = value;
            }
             
        }

        public double Height 
        {
            get { return this.height; } 
            private set
            {
                if (width < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive number");
                }
                this.height = value;
            } 
        }

        public abstract double CalculateSurface();
    }
}
