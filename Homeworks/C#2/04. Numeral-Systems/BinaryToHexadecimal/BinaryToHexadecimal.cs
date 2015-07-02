//Task 6
//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class BinaryToHexadecimal
    {
        static string BinaryToHex(string number)
        {
            switch (number)
            {
                case "1010": number = "A";
                    break;
                case "1011": number = "B";
                    break;
                case "1100": number = "C";
                    break;
                case "1101": number = "D";
                    break;
                case "1110": number = "E";
                    break;
                case "1111": number = "F";
                    break;
                case "0000": number = "0";
                    break;
                case "0001": number = "1";
                    break;
                case "0010": number = "2";
                    break;
                case "0011": number = "3";
                    break;
                case "0100": number = "4";
                    break;
                case "0101": number = "5";
                    break;
                case "0110": number = "6";
                    break;
                case "0111": number = "7";
                    break;
                case "1000": number = "8";
                    break;
                case "1001": number = "9";
                    break;
            }
            return number;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number in binary representation: ");
            string inputNumber = Console.ReadLine();
            string number = inputNumber.PadLeft(32, '0');
            //Console.WriteLine(number);

            string PartNumber = null;
            string outputNumber = null;
            string concatenator = null;
            for (int i = 1; i <= number.Length; i++)
            {
                concatenator += number[i - 1];
                if (i % 4 == 0)
                {
                    PartNumber = concatenator;
                    concatenator = null;
                    outputNumber += BinaryToHex(PartNumber);
                }

            }

            List<object> final = new List<object>(); 

            for (int i = 0; i < outputNumber.Length; i++)
            {
                if (outputNumber[i] != '0')
                {
                    for (int j = i; j < outputNumber.Length; j++)
                    {
                        final.Add((char)outputNumber[j]);
                    }
                    break;
                }
            }

            PrintList(final);
        }

        static void PrintList(List<object> final)
        {
            for (int i = 0; i < final.Count; i++)
            {
                Console.Write(final[i]);
            }
            Console.WriteLine();
        }
    }
