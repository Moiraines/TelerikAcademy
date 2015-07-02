//Task 24
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class OrderWords
    {
        static void Main()
        {
            string input = "The text is as follows We are living in an yellow submarine We don't have anything else inside the submarine is very tight So we are drinking all the day We will move out of it in 5 days";
            string[] splitString = input.Split(' ');
            Array.Sort(splitString);

            Console.WriteLine(String.Join(" ", splitString));
        }
    }
