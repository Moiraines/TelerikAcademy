namespace Methods
{
    using System;

    public class Methods
    {
        private static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides must be positive numbers!");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArithmeticException("input sides value cannot form a proper triangle");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        private static string DigitToTextRepresentation(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid digit!";
        }

        private static int FindMaxElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("array should not be empty");
            }

            Array.Sort(elements);
            return elements[elements.Length - 1];
        }

        private static void NumberAsStringFormat(double number, Format format)
        {
            switch (format)
            {
                case Format.Round: 
                    Console.WriteLine("{0:f2}", number);
                    break;
                case Format.Percent:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case Format.Alingment:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArithmeticException("invalid format");
            }
        }

        /// <summary>
        /// Calculate distance between two given points
        /// </summary>
        /// <returns>distance between the two points</returns>
        private static double CalcDistance(Point pointA, Point pointB)
        {
            double distance = Math.Sqrt(((pointB.CoordinateY - pointA.CoordinateY) * (pointB.CoordinateY - pointA.CoordinateY)) + ((pointB.CoordinateX - pointA.CoordinateX) * (pointB.CoordinateX - pointA.CoordinateX)));
            return distance;
        }

        /// <summary>
        /// check for equal coordinates of two input points
        /// </summary>
        /// <param name="coordinateA">abscissa or ordinate coordinate of the first point</param>
        /// <param name="coordinateB">abscissa or ordinate coordinate of the second point</param>
        /// <returns>return if are equal or not</returns>
        private static bool CheckForEqualCoordinates(double coordinateA, double coordinateB)
        {
            if(coordinateA == coordinateB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Main tester for all methods and classes in the homework
        /// </summary>
        private static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToTextRepresentation(5));

            Console.WriteLine(FindMaxElement(5, -1, 3, 2, 14, 2, 3));

            NumberAsStringFormat(1.3, Format.Round);
            NumberAsStringFormat(0.75, Format.Percent);
            NumberAsStringFormat(2.30, Format.Alingment);

            Point a = new Point(3, -1);
            Point b = new Point(3, 2.5);
            bool horizontal = CheckForEqualCoordinates(a.CoordinateY, b.CoordinateY);
            bool vertical = CheckForEqualCoordinates(a.CoordinateX, b.CoordinateX);
            Console.WriteLine(CalcDistance(a, b));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "17.03.1992");
            peter.AdditionalInfo = "From Sofia";

            Student stella = new Student("Stella", "Markova", "03.11.1993");
            stella.AdditionalInfo = "From Vidin, gamer, high results";

            Console.WriteLine(
                                "{0} older than {1} -> {2}",
                                peter.FirstName, 
                                stella.FirstName, 
                                peter.IsOlderThan(stella));
        }
    }
}
