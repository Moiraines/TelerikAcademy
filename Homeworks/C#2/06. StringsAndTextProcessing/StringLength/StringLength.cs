//Task 6
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class StringLength
    {
        static void Main()
        {
            string input = null;
            do
            {
                Console.WriteLine("Please enter string with Length with maximum 20 chars:");
                input = Console.ReadLine();
            } while (input.Length > 20);

            Console.Write("{0}", input);
            Console.WriteLine(new string('*', 20 - input.Length));
        }
    }
