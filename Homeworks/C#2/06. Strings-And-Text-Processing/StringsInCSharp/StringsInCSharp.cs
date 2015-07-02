//Task 1
//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class StringsInCSharp
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Description: 
    A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a string, use the StringInfo object.
 In most languages, a string is equivalent to an array of characters or code units, but Java treats them as distinct types (java.lang.String and char[]). Other languages (such as Python, and many dialects of BASIC) have no separate character type; strings with a length of one are normally used to represent (single code unit) characters.

Literals for characters and strings are usually surrounded by quotation marks: sometimes, single quotes (') are used for characters and double quotes ("") are used for strings. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Methods:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Clone - Returns a reference to this instance of String.");
            Console.WriteLine();
            Console.WriteLine("Compare(String, String) - Compares two specified String objects and returns an integer that indicates their relative position in the sort order.");
            Console.WriteLine();
            Console.WriteLine("Contains - Returns a value indicating whether a specified substring occurs within this string.");
            Console.WriteLine();
            Console.WriteLine("Format(String, Object) - Replaces one or more format items in a specified string with the string representation of a specified object.");
            Console.WriteLine();
            Console.WriteLine("IndexOf(Char) - Reports the zero-based index of the first occurrence of the specified Unicode character in this string.");
            Console.WriteLine();
            Console.WriteLine("Concat(String[]) - Concatenates the elements of a specified String array.");
            Console.WriteLine();
            Console.WriteLine("Split(Char[], StringSplitOptions) - Returns a string array that contains the substrings in this string that are delimited by elements of a specified Unicode character array. A parameter specifies whether to return empty array elements.");
            Console.WriteLine();
            Console.WriteLine("Replace(string, string) – replaces all occurrences of given string with another");
            Console.WriteLine();
            Console.WriteLine("Remove(index, length) – deletes part of a string and produces new string as result");
            Console.WriteLine();
            Console.WriteLine("ToLower()Returns a copy of this string converted to lowercase.");
            Console.WriteLine();
            Console.WriteLine("ToUpper() - Returns a copy of this string converted to uppercase.");
            Console.WriteLine();
            Console.WriteLine("Trim() - Removes all leading and trailing white-space characters from the current String object.");
            Console.WriteLine();
            Console.WriteLine("Length = Reports the number of chars in the string");
            Console.WriteLine();
            Console.WriteLine("IndexOf(Char) - Reports the zero-based index of the first occurrence of the specified Unicode character in this string.");
            Console.WriteLine();
            Console.WriteLine("Substring(Int32) - Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.");
            Console.WriteLine();
            Console.WriteLine("Remove - Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.");


            Console.ForegroundColor = ConsoleColor.White;
        }
    }
