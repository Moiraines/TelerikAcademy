//Task 6
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:
//input	            output
//"43 68 9 23 318"	461
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SumIntegers
    {
        static void StringToList(string input)
        {
            List<long> sequence = new List<long>();
            StringBuilder tempString = new StringBuilder();
            string tempToString = null;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    tempString.Append(input[i]);
                }
                
                if ((input[i] == ' ') || (i == input.Length - 1))
                {
                    tempToString = tempString.ToString();
                    sequence.Add(long.Parse(tempToString));
                    tempString.Clear();
                }
            }
            Console.WriteLine("Result: {0}", SumOfElements(sequence));
        }

        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "43 68 9 23 318";

            StringToList(input);
        }

        static long SumOfElements(List<long> sequence)
        {
            var sum = 0L;
            foreach (var element in sequence)
            {
                sum += element;
            }

            return sum;
        }
    }
