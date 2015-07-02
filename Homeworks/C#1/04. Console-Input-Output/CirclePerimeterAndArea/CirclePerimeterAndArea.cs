//Task 3
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
using System;
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            double r;
            Console.WriteLine("Please, enter radius value");
            bool correctNumber = double.TryParse(Console.ReadLine(), out r);
            while (!correctNumber || r <= 0)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = double.TryParse(Console.ReadLine(), out r);
            }
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine("Circle perimeter: {0:F2}\nCircle area: {1:F2}",perimeter, area);
        }
    }
