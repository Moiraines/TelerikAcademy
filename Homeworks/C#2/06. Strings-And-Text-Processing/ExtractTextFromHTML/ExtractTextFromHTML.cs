//Task 25
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:
//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ExtractTextFromHTML
    {
        static void Main()
        {
            string input = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body>	</html>";

            StringBuilder head = new StringBuilder();
            StringBuilder Body = new StringBuilder();
            int indexofTitle = input.IndexOf("</title>");

            if (indexofTitle > 0 && input[indexofTitle - 1] != '>')
            {
                for (int i = 0; i < indexofTitle; i++)
                {
                    head.Append(input[i]);
                }
                ExtractText(head);

                for (int i = indexofTitle; i < input.Length; i++)
                {
                    Body.Append(input[i]);
                }
                ExtractText(Body);

                Console.WriteLine("Title:{0}", ExtractText(head));
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Body.Append(input[i]);
                }
            }

            Console.WriteLine("Text:{0}", ExtractText(Body));
        }

        static StringBuilder ExtractText(StringBuilder input)
        {
            StringBuilder result = new StringBuilder();
            bool inTag = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    inTag = true;
                    continue;
                }
                else if (input[i] == '>')
                {
                    inTag = false;
                    continue;
                }

                if (inTag == false)
                {
                    if (i > 0 && input[i - 1] == '>')
                    {
                        result.Append(' ');
                    }
                    result.Append(input[i]);
                }
            }

            return result;
        }
    }
