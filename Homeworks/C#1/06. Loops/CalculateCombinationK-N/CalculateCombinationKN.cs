//Task 7
//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
using System;
    class CalculateCombinationKN
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
            for (uint i = 1; i <= k; i++)
            {
                result *= n--;
                result /= i;
            }
            Console.WriteLine(result);
        }
    }
