//Task 4
//Write a program to convert hexadecimal numbers to their decimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
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
                }
            }
            Console.WriteLine();
            Console.WriteLine(hexdecimalResult);
        }
    }
}
