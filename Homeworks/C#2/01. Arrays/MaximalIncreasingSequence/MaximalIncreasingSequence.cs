//Task 5
//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input	                  result
//3, 2, 3, 4, 2, 2, 4	  2, 3, 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "3, 2, 3, 4, 2, 2, 4";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            int counter = 1;
            int maxSequence = 0;
            int sequenceStart = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    if (array[i] <= array[i - 1])
                    {
                        counter = 1;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        sequenceStart = i + 1 - maxSequence;
                    }
                }
            }

            Console.WriteLine("The Maximal Sequence is: ");
            for (int i = sequenceStart; i < sequenceStart + maxSequence; i++)
            {
                if (i == sequenceStart + maxSequence - 1)
                {
                    Console.Write("{0}", array[i]);
                    break;
                }
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine();
        }
    }
