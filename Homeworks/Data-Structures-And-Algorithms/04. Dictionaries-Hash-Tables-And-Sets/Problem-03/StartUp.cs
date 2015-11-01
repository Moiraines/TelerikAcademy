namespace Problem_03
{   
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /*
    Write a program that counts how many times each word from given text file words.txt appears in it. The character 
    casing differences should be ignored. The result words should be ordered by their number of occurrences in the 
    text. Example:
    This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
    is -> 2
    the -> 2
    this -> 3
    text -> 6
    */
    public class StartUp
    {
        public static void Main()
        {
            var text = string.Empty;
            using (StreamReader reader = new StreamReader(@"../../words.txt"))
            {
                text = reader.ReadToEnd();
            }

            var words = text.Split(new char[] {' ', '.', ',', '-', '!', '?', '\'', '\r', '\n', '\t'},
                StringSplitOptions.RemoveEmptyEntries);

            var occurs = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!occurs.ContainsKey(words[i].ToLower()))
                {
                    occurs.Add(words[i].ToLower(), 1);
                }
                else
                {
                    occurs[words[i].ToLower()]++;
                }
            }

            Console.WriteLine("Result: ");

            foreach (KeyValuePair<string, int> pair in occurs.OrderBy(p => p.Value))
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
