//Task 20
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Palindromes
    {
        static void Main()
        {
            string text = "The text is as follows: We ABBA are living in an yellow submarine. We don't have anything else. inside the submarine is exe very tight. So we are drinking all the lamal day. We will move out of it in 5 days.";

            string[] splited = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool isPalindrome = true;
            List<string> list = new List<string>();
            for (int i = 0; i < splited.Length; i++)
            {
                for (int j = 0; j < splited[i].Length / 2; j++)
                {
                    if (splited[i][j] != splited[i][splited[i].Length - 1 -j])
                    {
                        isPalindrome = false;
                        break;
                    }
                    else
                    {
                        isPalindrome = true;
                    }
                }

                if (isPalindrome == true)
                {
                    list.Add(splited[i]);
                }
            }

            Console.WriteLine("Result: ");
            Console.WriteLine(String.Join(", ", list));
        }
    }
