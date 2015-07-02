//Task 9
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;
    class Trapezoids
    {
        static void Main()
        {
            double a;
            double b;
            double h;
            Console.WriteLine("Please enter parameters for the trapezoid: ");
            Console.Write("Side a: ");
            
            bool correctNumber = double.TryParse(Console.ReadLine(), out a);
            while (!correctNumber || a <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = double.TryParse(Console.ReadLine(), out a);
                }
            Console.Write("Side b: ");
            correctNumber = double.TryParse(Console.ReadLine(), out b);
            while (!correctNumber || b <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = double.TryParse(Console.ReadLine(), out b);
                }
            Console.Write("Height h: ");
            correctNumber = double.TryParse(Console.ReadLine(), out h);
            while (!correctNumber || h <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = double.TryParse(Console.ReadLine(), out h);
                }

            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area is: {0}", area);
        }
    }
