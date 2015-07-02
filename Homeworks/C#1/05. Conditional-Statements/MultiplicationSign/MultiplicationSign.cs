//Task 4
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
using System;
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter \"a\" number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"c\" number:");
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;

            Console.WriteLine();
            Console.WriteLine("Result:");

            if (product == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (product > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }

        }
    }
