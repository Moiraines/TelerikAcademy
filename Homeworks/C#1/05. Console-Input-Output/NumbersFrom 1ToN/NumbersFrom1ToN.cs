//Task 8
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
using System;
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out number);
            while (!correctNumber || number <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out number);
                }

            Console.WriteLine();

            for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
