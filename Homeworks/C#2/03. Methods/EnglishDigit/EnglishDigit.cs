//Task 3
//Write a method that returns the last digit of given integer as an English word.
//Examples:
//input	output
//512	two
//1024	four
//12309	nine
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class EnglishDigit
    {
        static string DigitAsWord(int number)
        {
            int result = number % 10;
            string word = null;
            switch (result)
            {
                case 0: { word = "zero";}
                    break;
                case 1: { word = "one"; }
                    break;
                case 2: { word = "two"; }
                    break;
                case 3: { word = "three"; }
                    break;
                case 4: { word = "four"; }
                    break;
                case 5: { word = "five"; }
                    break;
                case 6: { word = "six"; }
                    break;
                case 7: { word = "seven"; }
                    break;
                case 8: { word = "eight"; }
                    break;
                case 9: { word = "nine"; }
                    break;
            }
            return word;
        }
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            string result = DigitAsWord(number);
            Console.WriteLine();
            Console.WriteLine("The last digit of your number is {0}", result);
        }
    }
