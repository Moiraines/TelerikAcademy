//Task 19
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            string text = "ff.ff 844, 11@, 22.01.1945 25.08.209.8";

            string[] cleared = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> dates = new List<string>();
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < cleared.Length; i++)
            {
                for (int j = 0; j < cleared[i].Length; j++)
                {
                    if ((cleared[i])[j] == '.' || Char.IsDigit((cleared[i])[j]))
                    {
                        word.Append((cleared[i])[j]);
                    }
                    else
                    {
                        word.Clear();
                        break;
                    }
                }

                var countDigits = word.ToString().Where(c => Char.IsDigit(c)).Count();

               if (countDigits == 8 && word.ToString().IndexOf('.') == 2 && word.ToString().LastIndexOf('.') == 5)
               {
                   dates.Add(word.ToString());
               }
               word.Clear();
            }

            Console.WriteLine("Extracts are: ");
            foreach (var item in dates)
            {
                Console.WriteLine(item);
            }
        }
    }
