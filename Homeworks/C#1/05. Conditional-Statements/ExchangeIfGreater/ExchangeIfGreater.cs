//Task 1
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:
//a	b	result
//5	2	2 5
//3	4	3 4
//5.5	4.5	4.5 5.5
using System;
    class ExchangeIfGreater
    {
        static void Main()
        {
            double a;
            double b;
            double temp;

            Console.Write("a = ");
            bool correctNumber = double.TryParse(Console.ReadLine(), out a);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = double.TryParse(Console.ReadLine(), out a);
            }

            Console.Write("b = ");
            correctNumber = double.TryParse(Console.ReadLine(), out b);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = double.TryParse(Console.ReadLine(), out b);
            }

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine();
            Console.WriteLine(a + " " + b);
        }
    }
