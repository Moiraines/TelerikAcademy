//Task 9 
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SortingArray
    {
        static void Main()
        {
            Console.WriteLine("Enter an array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter start index of the portion: ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end index of the portion( make sure this number is lesser then array's length: ");
            int endIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("The maximal element in this portion is: {0}", MaximalElement(myArray, startIndex, endIndex));

            Console.WriteLine("Ascending order of array:\n{0}",String.Join(", ", AscendingSort(myArray)));

            Console.WriteLine("Descending order of array:\n{0}", String.Join(", ", DescendingSort(myArray)));
        }

        

        static int MaximalElement(int[] arr, int startIndex, int endIndex)
        {
            int maxElementPositon = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (arr[i] > arr[maxElementPositon])
                {
                    maxElementPositon = i;
                }
            }
            int temp = arr[maxElementPositon];
            arr[maxElementPositon] = arr[endIndex];
            arr[endIndex] = temp;

            return arr[endIndex];
        }

        static int[] DescendingSort(int[] arr)
        {
            int[] sortArray = new int[arr.Length];

            for (int i = 0; i < sortArray.Length; i++)
            {
               sortArray[i] =  MaximalElement(arr, 0, sortArray.Length - 1 - i);
            }

            return sortArray;
        }

        static int[] AscendingSort(int[] arr)
        {
            int[] sortArray = new int[arr.Length];
            int counter = sortArray.Length - 1;
            for (int i = 0; i < sortArray.Length; i++)
            {
                sortArray[counter] = MaximalElement(arr, 0, sortArray.Length - 1 - i);
                counter--;
            }

            return sortArray;
        }
    }
