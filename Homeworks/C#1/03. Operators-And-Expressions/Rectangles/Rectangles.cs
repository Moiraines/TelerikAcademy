//Task 4
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double perimeter = (2 * width) + (2 * height);
            double square = height * width;
            Console.WriteLine("Rectangle's perimeter is {0},\nRectangle's square is {1}", perimeter, square);
        }
    }
