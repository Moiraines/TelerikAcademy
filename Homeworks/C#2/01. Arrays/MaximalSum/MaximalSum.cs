//Task 8
//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8      2, -1, 6, 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            int currentSum = 0;
            int maxSum = int.MinValue;
            int sequenceStart = 0;
            int sequenceEnd = 0;
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    sequenceEnd = i;
                    sequenceStart = temp;
                }
                if (currentSum <= 0)
                {
                    currentSum = 0;
                    temp = i + 1;
                }

            }

            //print sequence loop
            Console.WriteLine("The sequence with maximum sum is: ");
            for (int i = sequenceStart; i <= sequenceEnd; i++)
            {
                Console.Write(array[i] + (i!=sequenceEnd?", ":""));
            }
            Console.WriteLine();
        }
    }
