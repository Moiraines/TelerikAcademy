//Task 11
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class BinarySearchRec
    {
        static void Main()
        {
            Console.WriteLine("Enter an array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(myArray);
            Console.WriteLine();
            //print the array after sorted for better visual
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + (i != myArray.Length - 1 ? "," : ""));
            }
            Console.WriteLine();

            Console.WriteLine("Enter a number you want to check");
            int keyElement = int.Parse(Console.ReadLine());
            int min = 0;
            int max = myArray.Length - 1;

            //assign the result from the method BinarySearchIterative to variable result of int type
            int result = BinarySearchRecursive(myArray, keyElement, min, max);

            if (result == -1)
            {
                Console.WriteLine("The number can not be found in the array");
            }
            else
            {
                Console.WriteLine("The number has been found in the array at index {0}", result);
            }

        }

        private static int BinarySearchRecursive(int[] myArray, int keyElement, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (keyElement == myArray[mid])
                {
                    return mid;
                }
                else if (keyElement < myArray[mid])
                {
                    return BinarySearchRecursive(myArray, keyElement, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(myArray, keyElement, mid + 1, max);
                }
            }
        }
    }
