//Task 10
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
using System;
    class FibonacciNumbers
    {
        static void Main()
        {
            ulong n;
            double fibonacciNum = 0;

            Console.WriteLine("Enter a number: ");
            bool correctNumber = ulong.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || n <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = ulong.TryParse(Console.ReadLine(), out n);
                }

            for (ulong i = 0; i < n; i++)
                {
                    fibonacciNum = ((Math.Pow((1 + Math.Sqrt(5)) / 2, i)) - (Math.Pow((1 - Math.Sqrt(5)) / 2, i))) / Math.Sqrt(5);
                    Console.Write("{0}, ", fibonacciNum);
                }
        }
    }
