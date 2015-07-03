namespace Size
{
    using System;

    public class Size
    {
        private double width;
        private double heigth;

        public Size(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width 
        {
            get 
            { 
                return this.Width; 
            }

            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width have to be a positive double value");
                }

                this.Width = value; 
            }
        }

        public double Heigth 
        {
            get 
            { 
                return this.Heigth; 
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width have to be a positive double value");
                }

                this.Heigth = value;
            }
        }

        public static Size GetRotatedSize(
            Size oldSize, double rotationAngel)
        {
            double oldWidth = oldSize.Width;
            double oldHeigth = oldSize.Heigth;
            var cos = Math.Cos(rotationAngel);
            var sin = Math.Sin(rotationAngel);

            var newWidth = Math.Abs((cos * oldWidth) + (sin * oldHeigth));
            var newHeigth = Math.Abs((sin * oldWidth) + (cos * oldHeigth));

            var roatedSize = new Size(newWidth, newHeigth);
            return roatedSize;
        }
    }
}
