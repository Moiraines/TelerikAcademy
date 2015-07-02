//Task 4
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class CompareTextFiles
    {
        static void Main()
        {
            StreamReader firstReader = new StreamReader(@"..\..\task4InputA.txt");
            StreamReader secondReader = new StreamReader(@"..\..\task4InputB.txt");
            FileCompare(FromFileToList(firstReader), FromFileToList(secondReader));
        }

        static void FileCompare(List<string> firstList, List<string> secondList)
        {
            int areEqualCounter = 0;
            int areNotEqualCounter = 0;
            for (int i = 0; i < firstList.Count; i++)
            {
                if (firstList[i].Equals(secondList[i]))
                {
                    areEqualCounter++;
                }
                else
                {
                    areNotEqualCounter++;
                }
            }

            Console.WriteLine("Equal Lines = {0}", areEqualCounter);
            Console.WriteLine("Equal Lines = {0}", areNotEqualCounter);
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

            return list;
        }
    }
