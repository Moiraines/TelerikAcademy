//Task 1
//Write a program that reads 3 real numbers from the console and prints their sum
using System;
    class SumOf3Numbers
    {
        static void Main()
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            Console.WriteLine("Enter the first number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out firstNumber);
            while (!correctNumber)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out firstNumber);
                }

            Console.WriteLine("Enter the second number: ");
            correctNumber = int.TryParse(Console.ReadLine(), out secondNumber);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out secondNumber);
            }

            Console.WriteLine("Enter the third number: ");
            correctNumber = int.TryParse(Console.ReadLine(), out thirdNumber);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out thirdNumber);
            }
            int sum = firstNumber + secondNumber +thirdNumber;
            Console.WriteLine("The sum of your numbers is: {0}", sum);
        }
    }
