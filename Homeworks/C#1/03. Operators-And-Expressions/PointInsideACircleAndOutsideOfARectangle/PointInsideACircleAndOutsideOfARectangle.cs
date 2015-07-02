//Task 10
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2)
using System;
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            double circleCenterX = 1.0;
            double circleCenterY = 1.0;
            double circleRad = 1.5;
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

            bool inCircle = (((pointX - circleCenterY) * (pointX - circleCenterY)) + ((pointY - circleCenterY) * (pointY - circleCenterY)) <= (circleRad * circleRad));
            bool outRectangle = (((pointX < -1)||(pointX > 5))||((pointY < -1)||(pointY > 1)));

            if (inCircle && outRectangle)
                {
                    Console.WriteLine("Yes");
                }
            else
                {
                    Console.WriteLine("No");
                }      
        }
    }
