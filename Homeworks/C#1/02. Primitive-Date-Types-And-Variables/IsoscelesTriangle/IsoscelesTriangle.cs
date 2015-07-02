//Task 8
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
using System;
using System.Text;
class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            char copyrightSymbol = '\u00A9';
            Console.WriteLine("   {0}", copyrightSymbol);
            Console.WriteLine("  {0} {0}", copyrightSymbol);
            Console.WriteLine(" {0}   {0}", copyrightSymbol);
            Console.WriteLine("{0} {0} {0} {0}", copyrightSymbol);

        }
    }
