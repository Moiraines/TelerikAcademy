//Task 1
//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\task1.txt");
            List<string> list = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                    
                }
            }
            Console.WriteLine("Result");
            for (int i = 0; i < list.Count; i+=2)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
