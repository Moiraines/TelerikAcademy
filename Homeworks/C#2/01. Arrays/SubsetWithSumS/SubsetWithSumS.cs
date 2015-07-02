//Task 16
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:

//input array	            S	            result
//2, 1, 2, 4, 3, 5, 2, 6	14	            yes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SubsetWithSumS
    {

        static int wantedSum;
        static bool solution = false;
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "2, 1, 2, 4, 3, 5, 2, 6";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                arr[i] = int.Parse(splitedString[i]);
            }
            Console.WriteLine("Enter sum S: ");
            wantedSum = int.Parse(Console.ReadLine());
            //wantedSum = 14;

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
            int sum = 0;
            for (int i = 0; i < elementsInSubset; i++)
            {
                sum += subset[i];
            }
            if (sum == wantedSum)
            {
                solution = true;
                Console.WriteLine("Result:");
                Console.WriteLine("Yes");
                Environment.Exit(0);
            }
        }
    }
