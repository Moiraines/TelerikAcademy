//Task 8
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            //string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //string word = "we";
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            string wordChecker = " " + word;
            StringBuilder temp = new StringBuilder();
            string final = null;

            for (int i = 0; i < text.Length; i++)
            {
                temp.Append(text[i]);
                if (text[i] == '.')
                {
                    if (temp.ToString().ToLower().Contains(wordChecker))
                    {
                        final += temp.ToString();
                    }
                    temp.Clear();
                }
            }

            Console.WriteLine("Result:\n{0}", final.Trim());
        }
    }
