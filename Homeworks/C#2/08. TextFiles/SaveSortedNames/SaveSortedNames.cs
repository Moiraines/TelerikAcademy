//Task 6
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	    output.txt
//Ivan          George
//Peter         Ivan
//Maria         Maria
//George	    Peter 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SaveSortedNames
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Task6Input.txt");
            CopyToFile(FromFileToList(reader));
        }

        static List<string> FromFileToList(StreamReader input)
        {
            List<string> list = new List<string>();
            using (input)
            {
                string line = input.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = input.ReadLine();
                }
            }
            list.Sort();

            return list;
        }

        static void CopyToFile(List<string> list)
        {
            StreamWriter streamWriter = new StreamWriter(@"..\..\task6Output.txt");
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
