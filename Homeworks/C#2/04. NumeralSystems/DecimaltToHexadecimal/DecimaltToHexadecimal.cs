//Task 3
//Write a program to convert decimal numbers to their hexadecimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class DecimaltToHexadecimal
    {
        static void Main()
        {
            long n;

            Console.WriteLine("Enter number: ");
            bool correctNumber = long.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || n < 0 || n > long.MaxValue)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = long.TryParse(Console.ReadLine(), out n);
            }
            string result = null;

            if (n == 0)
            {
                Console.WriteLine();
                Console.WriteLine("0");
            }

            while (n > 0)
            {
                switch (n % 16)
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
                n /= 16;
            }
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
