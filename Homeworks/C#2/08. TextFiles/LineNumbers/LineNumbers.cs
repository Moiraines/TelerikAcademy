//Task 3
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\task3Input.txt");
            List<string> list = new List<string>();
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(counter + ". " + line);
                    counter++;
                    line = reader.ReadLine();

                }
            }

            StreamWriter streamWriter = new StreamWriter(@"..\..\task3Output.txt");
            using (streamWriter)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    streamWriter.WriteLine(list[i]);
                }
                Console.WriteLine("The output file has been created");
            }

        }
    }
