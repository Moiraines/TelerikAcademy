//Task 14
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:
//input	output
//.NET	platform for applications from Microsoft
//CLR	managed execution environment for .NET
//namespace	hierarchical organization of classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class WordDictionary
    {
        static void Main()
        {
            Console.WriteLine("Enter a choice between .NET, CLR or namespace:");
            string input = Console.ReadLine();
            while (input != ".NET" && input != "CLR" && input != "namespace")
	        {
	            Console.WriteLine("Sorry we dont have any information for this. Try to write the correct termin: ");
                input = Console.ReadLine();
	        }
            
            string[,] dictionary = new string[100, 2];

            dictionary[0,0] = ".NET";
            dictionary[0,1] = "platform for applications from Microsoft";
            dictionary[1,0] = "CLR";
            dictionary[1,1] = "managed execution environment for .NET";
            dictionary[2,0] = "namespace";
            dictionary[2,1] = "hierarchical organization of classes";

            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                if (input == dictionary[i, 0])
                {
                    Console.WriteLine("Result: ");
                    Console.WriteLine(dictionary[i, 1]);
                    Environment.Exit(0);
                }
            }
        }
    }
