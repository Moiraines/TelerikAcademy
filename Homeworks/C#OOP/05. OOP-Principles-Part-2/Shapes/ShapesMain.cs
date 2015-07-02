//Task 1
//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
namespace Shapes
{
    using System;
    class ShapesMain
    {
        static void Main()
        {
            var triangle = new Triangle(4, 3);
            var rectangle = new Rectangle(12, 10);
            var square = new Square(10);

            Console.WriteLine("The Area of Triangle is: {0}", triangle.CalculateSurface());
            Console.WriteLine("The Area of Rectangle is: {0}", rectangle.CalculateSurface());
            Console.WriteLine("The Area of Square is: {0}", square.CalculateSurface());
        }
    }
}
