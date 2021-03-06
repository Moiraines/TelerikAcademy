﻿//Task 5
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
using System;
    class FormattingNumbers
    {
        static void Main()
        {
            int a;
            float b;
            float c;

            Console.WriteLine("Enter \"a\" number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out a);
            while (!correctNumber || a < 0 || a > 500)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out a);
            }

            Console.WriteLine("Enter \"b\" number: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter \"c\" number: ");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0,-10:X}|{1, 10}|{2,10:N2}|{3,10:N3}", a, Convert.ToString(a,2).PadLeft(10,'0'),b,c);

        }
    }
