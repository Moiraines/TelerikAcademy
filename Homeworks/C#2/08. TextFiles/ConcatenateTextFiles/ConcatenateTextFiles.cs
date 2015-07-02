//Task 2
//Write a program that concatenates two text files into another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class ConcatenateTextFiles
    {
        static void Main()
        {
            StreamReader readerFirst = new StreamReader(@"..\..\task2InputA.txt");
            StreamReader readerSecond = new StreamReader(@"..\..\task2InputB.txt");
            string fileFirst = readerFirst.ReadToEnd();
            string fileSecond = readerSecond.ReadToEnd();
            readerFirst.Close();
            readerSecond.Close();

            StreamWriter streamWriter = new StreamWriter(@"..\..\ConcatenatedFile.txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(fileFirst + Environment.NewLine + fileSecond);
                Console.WriteLine("The Concatenated File was created.");
            }

        }
    }