//Task 23
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:
//input	                    output
//aaaaabbbbbcdddeeeedssaa	abcdedsa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter a text as the example: ");
            string text = Console.ReadLine();
            //string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder result = new StringBuilder();
            List<char> list = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0 && text[i] == text[i - 1])
                {
                    continue;
                }
                result.Append(text[i]);
            }

            Console.WriteLine("Result:\n{0}", result);
        }
    }
