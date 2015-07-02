//Task 15
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:
//input
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//output
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ReplaceTags
    {
        static void Main()
        {
            string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

            //test it with different input if you want
            //string test = Console.ReadLine();

            text = ((text.Replace("<a href", "[URL")).Replace(@""">", "]")).Replace("</a>", "[/URL]"); // i hate to work with " symbol inside the string body :)
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '"')
                {
                    output.Append(text[i]);
                }
            }

            Console.WriteLine("Result:\n{0}", output.ToString());
        }
    }
