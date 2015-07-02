//Task 7
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;
    class PointInACircle
    {
        static void Main()
        {
            double circleCenterX = 0.0;
            double circleCenterY = 0.0;
            int circleRad = 2;
            double pointX;
            double pointY;
            bool coordinateXCheck;
            bool coordinateYCheck;
            Console.WriteLine("Enter X coordinate: ");
            coordinateXCheck = double.TryParse(Console.ReadLine(), out pointX);            
            while (!coordinateXCheck)
            {
                Console.WriteLine("Wrong input data!\nTry again: ");
                coordinateXCheck = double.TryParse(Console.ReadLine(), out pointX);
            }
            Console.WriteLine("Enter Y coordinate: ");
            coordinateYCheck = double.TryParse(Console.ReadLine(), out pointY);
            while (!coordinateYCheck)
            {
                Console.WriteLine("Wrong input data!\nTry again: ");
                coordinateXCheck = double.TryParse(Console.ReadLine(), out pointY);
            }
            bool isInside = (((pointX - circleCenterY) * (pointX - circleCenterY)) + ((pointY - circleCenterY) * (pointY - circleCenterY)) <= (circleRad * circleRad));

            Console.WriteLine("These coordinates are inside the circle = " + isInside);
        }
    }
