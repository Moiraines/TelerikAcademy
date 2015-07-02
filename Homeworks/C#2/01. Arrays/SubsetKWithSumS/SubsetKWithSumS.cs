//Task 17
//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SubsetKWithSumS
    {
        //It is equal to the last task, the only difference is the addition check for "elements if subset are equal to the number of K elements
        static int wantedSum;
        static int numberOfKElements;
        static bool solution = false;
        static void Main()
        {
            Console.WriteLine("Enter an array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter sum S: ");
            wantedSum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter K value for number of elements: ");
            numberOfKElements = int.Parse(Console.ReadLine());

            int[] subset = new int[arr.Length];
            for (int elementsInSubset = 1; elementsInSubset <= arr.Length; elementsInSubset++)
            {
                //invoke GenerateSubset Method
                GenerateSubset(arr, subset, 0, 0, elementsInSubset);
            }

            if (!solution)
            {
                Console.WriteLine("Ain't no subset with sum {0}.", wantedSum);
            }
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
            if (elementsInSubset != numberOfKElements)
            {
                return;
            }
            int sum = 0;
            for (int i = 0; i < elementsInSubset; i++)
            {
                sum += subset[i];
            }
            if (sum == wantedSum)
            {
                for (int i = 0; i < elementsInSubset; i++)
                {
                    Console.Write(subset[i] + (i!=elementsInSubset-1?", ":""));
                }
                Console.WriteLine();
                solution = true;
            }
        }
    }
