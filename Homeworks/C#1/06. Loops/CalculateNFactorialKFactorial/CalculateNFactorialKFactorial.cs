//Task 6
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720
using System;
    class CalculateNFactorialKFactorial
    {
        static void Main()
        {
            uint n;
            uint k;

            Console.WriteLine("Enter n: ");
            bool correctNumber = uint.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || (n < 1) || (n > 100))
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = uint.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("Enter k: ");
            correctNumber = uint.TryParse(Console.ReadLine(), out k);
            while (!correctNumber || (k >= n))
            {
                Console.WriteLine("k should be smaller then n.\nTry again: ");
                correctNumber = uint.TryParse(Console.ReadLine(), out k);
            }

            ulong result = 1;
            for (uint i = (k + 1); i <= n; i++)
			{
                result *= i;
			}

            Console.WriteLine(result);
        }
    }
