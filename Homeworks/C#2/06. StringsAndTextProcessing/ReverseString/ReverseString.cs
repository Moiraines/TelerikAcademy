//Task 2
//Write a program that reads a string, reverses it and prints the result at the console.
//Example:
//input	output
//sample	elpmas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ReverseString
    {
            static char[] ReverseNumbers(string input)
        {
            int counter = 0;
            char[] reverseString = new char[input.Length];
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseString[counter] = input[i];
                counter++;
            }

            return reverseString;
        }

        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            char[] reverse = ReverseNumbers(input);

            Console.WriteLine("Result:\n{0}", String.Join("", reverse));
        }
    }
