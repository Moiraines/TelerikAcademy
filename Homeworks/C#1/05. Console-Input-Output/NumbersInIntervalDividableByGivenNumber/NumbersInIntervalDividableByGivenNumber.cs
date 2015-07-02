//Task 11
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
using System;
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            int a;
            int b;
            int p = 0;

            Console.WriteLine("Enter START number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out a);
            while (!correctNumber || a <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out a);
                }

            Console.WriteLine("Enter END number: ");
            correctNumber = int.TryParse(Console.ReadLine(), out b);
            while (!correctNumber || b <= 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out b);
                }

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p = p + 1;
                    Console.Write("{0}, ", i);
                }                
            }

            Console.WriteLine("P = {0}", p);
        }
    }
