//Task 7
//Write a method that reverses the digits of given decimal number.
//Example:
//input	    output
//256	    652
//123.45	54.321
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ReverseNumber
    {
        static char[] ReverseNumbers(string number)
        {
            int counter = 0;
            char[] reverseNumber = new char[number.Length];
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverseNumber[counter] = number[i];
                counter++;
            }

            return reverseNumber;
        }

        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            string number = Console.ReadLine();

            char[] reverse = ReverseNumbers(number);

            Console.WriteLine("Result:\n{0}", String.Join("", reverse));
        }
    }
