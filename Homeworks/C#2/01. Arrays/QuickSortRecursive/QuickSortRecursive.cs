//Task 14
//Write a program that sorts an array of strings using the Quick sort algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuickSort
{
    static void Main(string[] args)
    {
        // examples for testing
        //int max = 9;
        //int[] arr = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };


        Console.WriteLine("Enter number of elements: ");
        int max = int.Parse(Console.ReadLine());

        int[] arr = new int[max];

        for (int i = 0; i < max; i++)
        {
            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
 
        // print the inputed array on the console
        Console.Write("Input int array  : ");
        Console.Write("\n");
        for (int k = 0; k < max; k++)
        {
            Console.Write(arr[k] + " ");
            Console.Write("\n");
        } 
 
        Console.WriteLine("QuickSort By Recursive Method");
        SortQuick(arr, 0, max - 1);
        for (int i = 0; i < max; i++)
            Console.WriteLine(arr[i]);
        Console.ReadLine();
    }

    static public void SortQuick(int[] arr, int left, int right)
    {
        // For Recusrion  
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                SortQuick(arr, left, pivot - 1);

            if (pivot + 1 < right)
                SortQuick(arr, pivot + 1, right);
        }
    }

    static public int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
                left++;

            while (arr[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}
