//Task 11
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
using System;
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int n;
            int min;
            int max;
            Console.WriteLine("Enter number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || n <= 0)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("Enter min value: ");
            correctNumber = int.TryParse(Console.ReadLine(), out min);
            while (!correctNumber || min < 0)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out min);
            }

            Console.WriteLine("Enter max value: ");
            correctNumber = int.TryParse(Console.ReadLine(), out max);
            while (!correctNumber || max <= min)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out max);
            }

            Random rnd = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(rnd.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
        }
    }
