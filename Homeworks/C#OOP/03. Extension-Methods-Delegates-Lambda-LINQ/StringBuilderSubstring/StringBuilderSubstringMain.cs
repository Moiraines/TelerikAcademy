//Task 1
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
//new StringBuilder and has the same functionality as Substring in the class String.
namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    public static class StringBuilderSubstringMain
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder("Hello Extension Methods");

            StringBuilder substring1 = test.Substring(3, 5);
            StringBuilder substring2 = StringBuilderSubstring.Substring(test, 3, 5);

            Console.WriteLine("Results should be the same =>\nsubstring1: {0}\nsubstring2: {1}", substring1, substring2);
        }
    }
}
