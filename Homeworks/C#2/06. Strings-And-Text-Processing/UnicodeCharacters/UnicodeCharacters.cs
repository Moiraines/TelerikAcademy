//Task 10
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:
//input	output
//Hi!	\u0048\u0069\u0021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            //string text = "Hi!";
            foreach (char c in text)
            {
                Console.Write("\\U{0:x4}", (int)c);
            }
            Console.WriteLine();
        }
    }
