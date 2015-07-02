﻿//Task 5
//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HexadecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please enter your hexadecimal number: ");
            string number = Console.ReadLine();
            string result = null;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': result += "1010";
                        break;
                    case 'B': result += "1011";
                        break;
                    case 'C': result += "1100";
                        break;
                    case 'D': result += "1101";
                        break;
                    case 'E': result += "1110";
                        break;
                    case 'F': result += "1111";
                        break;
                    case '0': result += "0000";
                        break;
                    case '1': result += "0001";
                        break;
                    case '2': result += "0010";
                        break;
                    case '3': result += "0011";
                        break;
                    case '4': result += "0100";
                        break;
                    case '5': result += "0101";
                        break;
                    case '6': result += "0110";
                        break;
                    case '7': result += "0111";
                        break;
                    case '8': result += "1000";
                        break;
                    case '9': result += "1001";
                        break;
                    default: Console.WriteLine("Invalid syntax of a number");
                        Environment.Exit(0);
                        break;
                }
            }
            Console.WriteLine("The result is: ");
            Console.WriteLine(result);
        }
    }
