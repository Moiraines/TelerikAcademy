//Task 6
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class FirstLargerThanNeighbours
    {
        static int LargerThenNeighbors(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    return i - 1;
                }
            }
            
            return -1;
        }

        static void Main()
        {
            Console.WriteLine("Enter array's elements like the commented example: ");
            string input = Console.ReadLine();
            //string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            Console.WriteLine("Result:\n" + LargerThenNeighbors(array));
        }
    }
