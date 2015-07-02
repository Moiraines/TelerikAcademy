//Task 18
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
using System;
using System.Numerics;
    class TrailingZeroesInNFactorial
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out n);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out n);
            }

            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            string result = Convert.ToString(factorial);

            int counter = 0;
            for (int j = result.Length - 1; j >= 0; j--)
            {
                if (result[j] != '0')
                {
                    break;
                }
                counter += 1;
            }
            
            Console.WriteLine();
            Console.WriteLine("trailing zeroes of n!:\n{0}", counter);

            if (factorial < ulong.MaxValue)
            {
               Console.WriteLine("explaination:\n{0}", result);
            }
            else
	        {
                Console.WriteLine("explaination:\nthink why");
	        }
            
          
        }
    }
