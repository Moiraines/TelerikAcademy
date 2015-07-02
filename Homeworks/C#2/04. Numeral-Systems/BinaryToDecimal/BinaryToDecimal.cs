//Task 2
//Write a program to convert binary numbers to their decimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary number (only 0s or 1s): ");
            string number = Console.ReadLine();
            long decimalResult = 0;

            for (int i = 0; i < number.Length; i++)
            {
                decimalResult = (decimalResult << 1) + (number[i] == '1' ? 1 : 0);
            }
            Console.WriteLine();
            Console.WriteLine(decimalResult);
        }
    }
