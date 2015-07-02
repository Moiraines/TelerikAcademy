//Task 7
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please the number: ");

            string[] input = Console.ReadLine().Split();

            double number1 = Convert.ToDouble(input[0]);
            double number2 = Convert.ToDouble(input[1]);
            double number3 = Convert.ToDouble(input[2]);
            double number4 = Convert.ToDouble(input[3]);
            double number5 = Convert.ToDouble(input[4]);
            double sum = number1 + number2 + number3 + number4 + number5;

            Console.WriteLine(sum);
        }
    }
