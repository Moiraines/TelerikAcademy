//Task 10
//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            string line = string.Empty;

            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i - 1] == '>')
                        {
                            do
                            {
                                text.Append(line[i]);
                                i++;
                            }
                            while (line[i] != '<');

                            Console.WriteLine(text.ToString());
                            text.Clear();
                        }
                    }
                }
            }
        }
    }
}
