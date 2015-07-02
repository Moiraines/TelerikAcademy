//Task 13
//Write a program that reverses the words in given sentence.
//Example:
//input	                                    output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ReverseSentence
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            string[] splitedString = text.Split(new char[]{' ', '!'}, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Reversed: {0}!", String.Join(" ", splitedString.Reverse())); 
        }
    }
