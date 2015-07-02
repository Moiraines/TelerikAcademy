//Task 1
//using Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:
//n	output
//3	1 2 3
//5	1 2 3 4 5System;
using System;
    class NumbersFrom1ToN
    {
        static void Main()
        {
            System.Console.WriteLine("Enter na number:");
            uint n = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
    }
