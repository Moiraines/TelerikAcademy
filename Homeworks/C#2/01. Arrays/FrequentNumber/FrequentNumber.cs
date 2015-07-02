//Task 9
//Write a program that finds the most frequent number in an array.
//Example:
//input	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	        4 (5 times)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class FrequentNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            Array.Sort(array);

            int counter = 1;
            int maxCount = 0;
            int mostFrequentNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                
                if (array[i] == array[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                    
                if (counter > maxCount)
                {
                    maxCount = counter;
                    mostFrequentNumber = array[i];
                }
                
            }

            Console.WriteLine("The most frequent number is: {0} ({1} times)", mostFrequentNumber, maxCount);
        }
    }
