//Task 22
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class WordsCount
    {
        static void Main()
        {
            string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] splitedText = text.ToLower().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int counter;

            List<string> words = new List<string>();
            List<int> count = new List<int>();

            for (int i = 0; i < splitedText.Length; i++)
            {
                counter = 1;
                if (i > 0 && words.Contains(splitedText[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < splitedText.Length; j++)
                {
                    if (splitedText[i] == splitedText[j])
                    {
                        counter++;
                    }
                }
                words.Add(splitedText[i]);
                count.Add(counter);
            }

            Console.WriteLine("Result: ");
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("Word: {0}, Count: {1}", words[i], count[i]);
            }
        }
    }
