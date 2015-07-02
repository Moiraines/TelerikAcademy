//Task 9
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ForbiddenWords
    {
        static void Main()
        {

            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            List<string> list = new List<string>
            {
                "PHP",
                "CLR",
                "Microsoft"
            };
            foreach (var word in list)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine("Result:\n{0}", text);
        }
    }
