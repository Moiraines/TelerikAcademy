//Task 18
//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.
//Example:
//input	                            result
//6, 1, 4, 3, 0, 3, 6, 4, 5	        1, 3, 3, 4, 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class RemoveElementsFromArray
    {
        static int[] output;
        static int maxLength;
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "6, 1, 4, 3, 0, 3, 6, 4, 5";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                arr[i] = int.Parse(splitedString[i]);
            }

            output = new int[arr.Length];
            int[] subset = new int[arr.Length];
            for (int elementsInSubset = 1; elementsInSubset <= arr.Length; elementsInSubset++)
            {
                //invoke GenerateSubset Method
                GenerateSubset(arr, subset, 0, 0, elementsInSubset);
            }

            for (int i = 0; i <= maxLength; i++)
            {
                Console.Write(output[i] + (i!=maxLength?", ":"" ));
            }
            Console.WriteLine();
        }

        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)
            {
                //invoke CheckSubsets Method
                CheckSubsets(subset, elementsInSubset);
                return;
            }

            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            for (int i = 1; i < elementsInSubset; i++)
            {
                if (subset[i] < subset[i - 1])
                {
                    return;
                }
                if (i > maxLength)
                {
                    maxLength = i;
                    for (int j = 0; j <= maxLength; j++)
                    {
                        output[j] = subset[j];
                    }
                }
            }
        }
    }

