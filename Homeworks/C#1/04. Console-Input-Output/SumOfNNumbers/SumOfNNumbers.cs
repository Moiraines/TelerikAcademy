//Task 9
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
using System;
    class SumOfNNumbers
    {
        static void Main()
        {
            long number;
            double subnumber;
            double sum = 0;

            Console.WriteLine("Enter a number: ");
            bool correctNumber = long.TryParse(Console.ReadLine(), out number);
            while (!correctNumber || number <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = long.TryParse(Console.ReadLine(), out number);
                }

            for (long i = 1; i <= number; i++)
                {
                    Console.WriteLine("Enter number for calculation: ");

                    subnumber = double.Parse(Console.ReadLine());
                    sum = sum + subnumber;
               
                }
            Console.WriteLine();
            Console.WriteLine("Sum = {0}", sum);
        }
    }
