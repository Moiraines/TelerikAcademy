//Task 14*
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
using System;
using System.Text;
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("ASCII Symbols: ");
            for (int symbol = 0; symbol <= 255; symbol++)
            {
                Console.WriteLine((char)symbol);
            }

        }
    }
