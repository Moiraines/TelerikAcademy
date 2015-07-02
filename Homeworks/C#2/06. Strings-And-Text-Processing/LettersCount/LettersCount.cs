//Task 21
//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class LettersCount
    {
        static void Main()
        {
            string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            StringBuilder letters = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
			{
			    if (Char.IsLetter(text[i]))
	            {
                    letters.Append(text.ToLower()[i]);
	            }
			}
            List<char> list = new List<char>();
            List<int> count = new List<int>();
            int counter;
            for (int i = 0; i < letters.Length; i++)
            {
                counter = 1;
                if (i > 0 && list.Contains(letters[i]))
                {
                    continue;
                }
                for (int j = i + 1; j < letters.Length; j++)
                {
                    if (letters[i] == letters[j])
                    {
                        counter++;
                    }
                }
                list.Add(letters[i]);
                count.Add(counter);
            }

            Console.WriteLine("Result: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Letter: {0}, Count: {1}", list[i], count[i]);
            }
        }
    }
