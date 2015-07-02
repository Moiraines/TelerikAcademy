//Task 10
//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
    class NFactorial
    {
        static BigInteger Factorial(int[] arr)
        {
            BigInteger result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 100: ");
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine("The Factorial = {0}", Factorial(arr));
        }
    }
