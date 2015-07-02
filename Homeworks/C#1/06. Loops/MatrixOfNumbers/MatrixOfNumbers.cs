//Task 9
//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
using System;
    class MatrixOfNumbers
    {
        static void Main()
        {
            uint n;

            Console.WriteLine("Enter n: ");
            bool correctNumber = uint.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || (n < 1) || (n > 20))
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = uint.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine();
            uint k = 0;

            for (uint i = 1; i <= n; i++)
            {
                for (uint j = i; j < n + i; j++)
                {
                    Console.Write("{0,2} ", j);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
