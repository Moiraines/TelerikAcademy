//Task 18
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ExtractEMails
    {
        static void Main()
        {
            string text = "This is our mail: fens@abv.bg. Please lyubomir@com@alabala.bg use it instead of culture@abv.bg, since it is our old one. This is fake mail: com.yahoo@office";
            string[] cleared = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> mails = new List<string>();
            for (int i = 0; i < cleared.Length; i++)
            {
                if (cleared[i].Contains('@') && cleared[i].IndexOf('@') == cleared[i].LastIndexOf('@'))
                {
                    if (cleared[i][cleared[i].Length - 1] == ('.'))
                    {
                        cleared[i] = cleared[i].Substring(0, cleared[i].Length - 1);
                    }

                    if (cleared[i].Contains('.') && cleared[i].IndexOf('@') < cleared[i].IndexOf('.'))
                    {
                        mails.Add(cleared[i]);
                    }
                }
            }
            Console.WriteLine("Result: ");
            Console.WriteLine(String.Join(", ", mails));

        }
    }
