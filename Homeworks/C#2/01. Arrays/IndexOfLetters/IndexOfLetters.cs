//Task 12
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class IndexOfLetters
    {
        static void Main()
        {
            //declare the array with the alphabet capital letters
            char[] myArray = new char[26];

            int index = 65;
            for (int i = 0; i < 26; i++)
            {
                myArray[i] = (char)index;
                index += 1;
            }


            Console.WriteLine("Please enter a word (use only capital letters please): ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (word[i] == myArray[j])
                    {
                        Console.WriteLine("{0} has an index {1} in the Array", word[i], j);
                    }

                }
            }
        }
    }
