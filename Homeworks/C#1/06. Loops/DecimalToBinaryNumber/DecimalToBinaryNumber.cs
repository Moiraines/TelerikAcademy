//Task 14
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
using System;

namespace DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            long n;

            Console.WriteLine("Enter number: ");
            bool correctNumber = long.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || n < 0 || n > long.MaxValue)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = long.TryParse(Console.ReadLine(), out n);
            }
            string result = null;

            if (n == 0)
            {
                Console.WriteLine();
                Console.WriteLine("0");
            }

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    result = "0" + result;
                }
                else
                {
                    result = "1" + result;
                }
                n /= 2;
            }
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
