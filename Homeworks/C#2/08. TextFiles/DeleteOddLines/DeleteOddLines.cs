//Task 9
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            //input:
            //1
            //2
            //3
            //4
            //5
            //6
            //7
            //8
            //9
            //10
            StringBuilder text = new StringBuilder();

            SelectEvenLines(text);

            WriteTextInFile(text);
        }

        private static void WriteTextInFile(StringBuilder text)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
            {
                writer.Write(text);
            }
        }

        private static void SelectEvenLines(StringBuilder text)
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                string line = reader.ReadLine();
                int count = 1;

                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        text.Append(line);

                        if (!reader.EndOfStream)
                        {
                            text.Append("\r\n");
                        }
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
