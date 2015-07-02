namespace Point3D
{
    using System;
    public class Distance3D // task 3
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                                        (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
                                        (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));

            return distance;
        }
    }
}
