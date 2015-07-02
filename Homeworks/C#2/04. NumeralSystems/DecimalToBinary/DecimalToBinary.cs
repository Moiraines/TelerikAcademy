//Task 1
//Write a program to convert decimal numbers to their binary representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class DecimalToBinary
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
