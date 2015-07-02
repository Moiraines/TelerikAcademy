//Task 8
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
using System;
using System.Numerics;
    class CatalanNumbers
    {
        static void Main()
        {
            BigInteger n;

            Console.WriteLine("Enter n: ");
            bool correctNumber = BigInteger.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || (n < 0) || (n >= 100))
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = BigInteger.TryParse(Console.ReadLine(), out n);
            }

            BigInteger factorial = 1;

            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (BigInteger i = n + 1; i <= 2 * n; i++)
                {
                    factorial *= i;
                }

                for (BigInteger j = 1; j <= n + 1; j++)
                {
                    factorial /= j;
                }
                Console.WriteLine(factorial);
            }
            
            
            
        }
    }