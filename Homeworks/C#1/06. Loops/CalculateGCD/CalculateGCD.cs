//Task 17
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
using System;
    class CalculateGCD
    {
        static void Main()
        {
            int a;
            int b;

            Console.WriteLine("Enter a number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out a);
            while (!correctNumber || a < int.MinValue || a > int.MaxValue)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out a);
            }

            Console.WriteLine("Enter b number: ");
            correctNumber = int.TryParse(Console.ReadLine(), out b);
            while (!correctNumber || b < int.MinValue || b > int.MaxValue)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out b);
            }

            int result = GCD(a, b);
            Console.WriteLine();
            Console.WriteLine("GCD is: " + result);
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (Math.Abs(a) > Math.Abs(b))
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
            return b;
            else
            return a;
        }

    }
