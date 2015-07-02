//Task 7
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class ReplaceSubstring
    {
        static void Main()
            //Check the file before execute
        {
            StringBuilder sb = new StringBuilder();

            ReplaceWords(sb);

            WriteFileWithNewText(sb);
        }

        private static void WriteFileWithNewText(StringBuilder sb)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
            {
                writer.Write(sb);
            }
        }

        private static void ReplaceWords(StringBuilder sb)
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    sb.Append(line).Replace("start", "finish");

                    if (!reader.EndOfStream)
                    {
                        sb.Append("\r\n");
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
