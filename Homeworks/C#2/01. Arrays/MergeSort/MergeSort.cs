//Task 13
//Write a program that sorts an array of integers using the Merge sort algorithm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSortAlgorithm
    {

        //The problem has been solved with recursion. One main method, one method for Sorting with recursion in itself and one method for Merge.
        static void Main()
        {
            //demo testing
            //int[] arr = { 6, 5, 4, 2, 8, 7, 2, 4 };
            Console.WriteLine("Enter an array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            arr = MergeSort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
 
        private static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    left[i] = arr[i];
                }
                else
                {
                    right[i - middle] = arr[i];
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }
 
        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i;
            int j;
            for ( i = 0, j =0; i < left.Length && j < right.Length;)
            {
                if (left[i] < right[j])
                {
                    result[i+j] = left[i];
                    i++;
                }
                else
	            {
                    result[i+j] = right[j];
                    j++;
	            }
            }

            for (; i < left.Length; i++)
            {
                result[i + j] = left[i];
            }

            for (; j < right.Length; j++)
            {
                result[i + j] = right[j];
            }

            return result;
        }
    }
}
