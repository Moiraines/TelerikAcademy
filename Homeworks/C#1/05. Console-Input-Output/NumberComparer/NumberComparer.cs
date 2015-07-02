//Task 4
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            bool compare = a > b;

            Console.WriteLine();
            Console.WriteLine(compare ? ("The greater number is " + a) : ("The greater number is " + b));
        }
    }
