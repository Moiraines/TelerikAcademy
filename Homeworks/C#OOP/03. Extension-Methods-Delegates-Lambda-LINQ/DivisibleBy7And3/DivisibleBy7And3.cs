using System;
//Task 6
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System.Linq;
namespace DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main()
        {
            var testArray = new int[100];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = i + 1;
            }
            Console.WriteLine("Numbers in the test array:\n{0}", string.Join(", ", testArray));

            var result = testArray.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine("Numbers, divisible by 3 and 7 (using lambda):\n{0}", string.Join(", ", result));

            var result2 =
                from number in testArray
                where number % 3 == 0 && number % 7 == 0
                select number;

            Console.WriteLine("Numbers, divisible by 3 and 7 (using LINQ):\n{0}", string.Join(", ", result));
        }
    }
}
