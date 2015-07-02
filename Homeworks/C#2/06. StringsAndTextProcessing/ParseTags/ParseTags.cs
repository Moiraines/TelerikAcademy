//Task 5
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ParseTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            StringBuilder builder = new StringBuilder();

            bool inTags = false;
            bool betweenTags = false;
            bool flag = false;
            string temp = null;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<' && betweenTags == true)
                {
                    inTags = true;
                    betweenTags = false;
                }
                else if (text[i] == '<' && betweenTags == false)
                {
                    inTags = true;
                }
                else if (text[i] == '>' && flag == false)
                {
                    betweenTags = true;
                    inTags = false;
                }
                else if (text[i] == '>' && flag == true)
                {
                    flag = false;
                    inTags = false;
                }
                else if (text[i] == '/')
                {
                    flag = true;
                }

                if (text[i] != '>')
                {
                    if (betweenTags == true)
                    {
                        temp = text[i].ToString();
                        builder.Append(temp.ToUpper());
                        temp = null;
                    }
                    else if (inTags != true)
                    {
                        builder.Append(text[i]);
                    }
                }
                
            }

            Console.WriteLine("Result:\n{0}", builder);
        }
    }
