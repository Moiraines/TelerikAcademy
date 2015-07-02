//Task 5
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
using System;
    class CalculateSomething
    {
        static void Main()
        {
            double s = 1.0;
            double divider;
            int n;
            int x;
            ulong factorial = 1;

            Console.WriteLine("Enter n: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out n);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("Enter x: ");
            correctNumber = int.TryParse(Console.ReadLine(), out x);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out x);
            }

            for (int i = 1; i <= n; i++)
            {
                factorial *= (ulong)i;
                divider = Math.Pow(x, i);
                s += factorial / divider;
            }

            Console.WriteLine("Sum = {0:F5}", s);

        }
    }
