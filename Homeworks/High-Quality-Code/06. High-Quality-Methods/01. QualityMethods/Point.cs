namespace Methods
{
    using System;

    internal class Point
    {
        internal Point(double coordinateX, double coordinateY)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
        }

        internal double CoordinateX { get; set; }

        internal double CoordinateY { get; set; }
    }
}
