//Task 15
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
using System;
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a hexadecimal number");
            string number = Console.ReadLine();
            long hexdecimalResult = 0;



            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 10;
                        break;
                    case 'B': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 11;
                        break;
                    case 'C': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 12;
                        break;
                    case 'D': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 13;
                        break;
                    case 'E': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 14;
                        break;
                    case 'F': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 15;
                        break;
                    case '0': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 0;
                        break;
                    case '1': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 1;
                        break;
                    case '2': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 2;
                        break;
                    case '3': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 3;
                        break;
                    case '4': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 4;
                        break;
                    case '5': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 5;
                        break;
                    case '6': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 6;
                        break;
                    case '7': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 7;
                        break;
                    case '8': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 8;
                        break;
                    case '9': hexdecimalResult = hexdecimalResult + (long)Math.Pow(16, (number.Length - 1 - i)) * 9;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(hexdecimalResult);
        }
    }
