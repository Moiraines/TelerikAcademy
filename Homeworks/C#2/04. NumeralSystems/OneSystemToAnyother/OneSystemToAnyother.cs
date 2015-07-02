//Task 7
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2<=s, d<=16).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class OneSystemToAnyother
    {
        static void Main()
        {
            Console.WriteLine("Enter a base for input numeral system:");
            short inputNSIndex = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            string inputNumber = Console.ReadLine();

            Console.WriteLine("Enter a base for output numeral system:");
            short outputNSIndex = short.Parse(Console.ReadLine());

            //use a method for convert the input numeral system to decimal
            long decimalResult = ConvertToDecimalAlgorithm(inputNumber, inputNSIndex);

            //use a method for convert decimal to output numera system
            string outputNumber = ConvertFromDecimalAlgorithm(decimalResult, outputNSIndex);

            Console.WriteLine("Result:\n{0} ", outputNumber);
        }

        static long ConvertToDecimalAlgorithm(string number, short inputIndex)
        {
            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 10;
                        break;
                    case 'B': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 11;
                        break;
                    case 'C': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 12;
                        break;
                    case 'D': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 13;
                        break;
                    case 'E': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 14;
                        break;
                    case 'F': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 15;
                        break;
                    case '0': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 0;
                        break;
                    case '1': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 1;
                        break;
                    case '2': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 2;
                        break;
                    case '3': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 3;
                        break;
                    case '4': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 4;
                        break;
                    case '5': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 5;
                        break;
                    case '6': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 6;
                        break;
                    case '7': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 7;
                        break;
                    case '8': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 8;
                        break;
                    case '9': result = result + (long)Math.Pow(inputIndex, (number.Length - 1 - i)) * 9;
                        break;
                }
            }

            return result;
        }

        static string ConvertFromDecimalAlgorithm(long number, short outputIndex)
        {
            string result = null;

            if (number == 0)
            {
                Console.WriteLine();
                Console.WriteLine("0");
            }

            while (number > 0)
            {
                switch (number % outputIndex)
                {
                    case 0: result = "0" + result;
                        break;
                    case 1: result = "1" + result;
                        break;
                    case 2: result = "2" + result;
                        break;
                    case 3: result = "3" + result;
                        break;
                    case 4: result = "4" + result;
                        break;
                    case 5: result = "5" + result;
                        break;
                    case 6: result = "6" + result;
                        break;
                    case 7: result = "7" + result;
                        break;
                    case 8: result = "8" + result;
                        break;
                    case 9: result = "9" + result;
                        break;
                    case 10: result = "A" + result;
                        break;
                    case 11: result = "B" + result;
                        break;
                    case 12: result = "C" + result;
                        break;
                    case 13: result = "D" + result;
                        break;
                    case 14: result = "E" + result;
                        break;
                    case 15: result = "F" + result;
                        break;
                }
                number /= outputIndex;
            }
            return result;
        }
    }
