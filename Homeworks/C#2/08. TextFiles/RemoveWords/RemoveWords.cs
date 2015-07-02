//Task 12
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                string text = ReadText();
                string[] words = ReadWords();

                RemoveListedWords(text, words);
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine(fnf.Message);
            }
            catch (DirectoryNotFoundException dnf)
            {
                Console.WriteLine(dnf.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (OutOfMemoryException ome)
            {
                Console.WriteLine(ome.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static void RemoveListedWords(string text, string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                text = text.Replace(words[i], "");
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
            {
                writer.Write(text);
            }
        }

        private static string ReadText()
        {
            string text = string.Empty;

            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        private static string[] ReadWords()
        {
            string[] words;

            using (StreamReader reader = new StreamReader(@"..\..\words.txt"))
            {
                words = reader.ReadToEnd().Replace("\r\n", " ").Split(' ');
            }

            return words;
        }
    }
