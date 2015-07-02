﻿//Task 13
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
using System;
class ComparingFloats
    {
    static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double c = Math.Abs(number1 - number2);
            double eps = 0.000001;
            if (c <= eps)
                {
                    Console.WriteLine("The Numbers are Equal");
                }
            else
                {
                    Console.WriteLine("The Numbers are NOT Equal");
                }
        }
    }
