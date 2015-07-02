//Task 1
//Write an expression that checks if given integer is odd or even.
using System;
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
                if ((number % 2 == 0))
            {
                Console.WriteLine("The number is Equal");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
