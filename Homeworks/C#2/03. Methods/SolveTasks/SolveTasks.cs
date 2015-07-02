//Task 13
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SolveTasks
    {
        static void ReverseDigits(string input)
        {
            int counter = 0;
            char[] reverseNumber = new char[input.Length];
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseNumber[counter] = input[i];
                counter++;
            }

            Console.WriteLine("The reverse number of your number is:\n{0}", String.Join("", reverseNumber));
        }

        static void AverageofSequence(int input)
        {
            double sum = 0.0;
            double[] arr = new double[input];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] number:");
                arr[i] = double.Parse(Console.ReadLine());
                sum += arr[i];
            }
            sum = sum / arr.Length;

            Console.WriteLine("The Average sum is:\n{0}", sum);
        }

        static void LineraEquation(double firstNumber, double secondNumber)
        {
            double result = -(secondNumber / firstNumber);

            Console.WriteLine("Result: \nx = {0}", result);
        }

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose what kind a problem you need to solve:");
            Console.WriteLine("A) Reverse the digit of a number");
            Console.WriteLine("B) Calculate the average of a sequence of integers");
            Console.WriteLine("C) Solves a linear equation a * x + b = 0");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.ForegroundColor = ConsoleColor.White;
            string option = Console.ReadLine();

            string refinedOption = option.ToLower();

            switch (refinedOption)
            {
                case "a":
                    {
                        Console.WriteLine("Not so cool choise, its the cheapest option in our show! :)");
                        Console.WriteLine("Enter your number, and make sure that is a positive one or something bad\nwill happend:");
                        string number = Console.ReadLine();
                        number = DigitCheck(number);
                        ReverseDigits(number);   
                    }
                    break;
                case "b":
                    {
                        Console.WriteLine("Excellent choise!");
                        Console.WriteLine("Enter count of numbers for the sequence:");
                        int input = int.Parse(Console.ReadLine());
                        input = IsSequenceEmptyCheck(input);
                        AverageofSequence(input);
                    }
                    break;
                case "c":
                    {
                        Console.WriteLine("Excellent choise!");
                        Console.WriteLine("Enter \"a\" number != 0: ");
                        double a = double.Parse(Console.ReadLine());
                        a = IsAEqualToZeroCheck(a);
                        Console.WriteLine("Enter \"b\" number: ");
                        double b = double.Parse(Console.ReadLine());
                        LineraEquation(a, b);

                    }
                    break;
                default:
                    {
                        while (refinedOption != "a" && refinedOption != "b" && refinedOption != "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice\nTry again: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            refinedOption = Console.ReadLine();
                        }
                    }
                    break;
            }
        }

        static string DigitCheck(string number)
        {
            while (number[0] == '-')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOUR HAVE BEEN CURSED! BADLY! You shouldn't enter a negative number!\nWe told you so!\nIf you want to remove the bad spell try again and this time do it right :):");
                Console.ForegroundColor = ConsoleColor.White;
                number = Console.ReadLine();
            } 
            return number;
        }

        static double IsAEqualToZeroCheck(double number)
        {
            
            while (number == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a must be different then zero.\nTry again: ");
                Console.ForegroundColor = ConsoleColor.White;
                number = double.Parse(Console.ReadLine());
            }
            return number;
        }

        static int IsSequenceEmptyCheck(int input)
        {

            while (input.Equals(""))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You should put something there. No more cheapshots:)\nTry again :");
                Console.ForegroundColor = ConsoleColor.White;
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
    }
