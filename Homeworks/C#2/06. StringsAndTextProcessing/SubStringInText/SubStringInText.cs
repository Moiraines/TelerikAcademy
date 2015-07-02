//Task 4
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SubStringInText
    {
        static void Main()
        {
            string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string insensitive = text.ToLower();
            string subString = "in";
            int counter = 0;
            for (int i = 0; i < insensitive.Length; i++)
            {
                if (insensitive[i] == subString[1] && insensitive[i - 1] == subString[0] && i > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("Result\n{0}", counter);
        }
    }
