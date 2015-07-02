//Task 3
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
using System;
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int number;
            int subnumber;
            long sum = 0L;
            double avg;
            

            Console.WriteLine("Enter a number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out number);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out number);
            }

            int min = number;
            int max = number;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Enter number for calculation: ");
                subnumber = int.Parse(Console.ReadLine());

                if (max < subnumber)
                {
                    max = subnumber;
                }
                if (min > subnumber)
                {
                    min = subnumber;
                }
                sum = sum + subnumber;              
            }

            avg = (double)sum / (double)number;
            Console.WriteLine();
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
        }
    }
