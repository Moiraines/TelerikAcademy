//Task 5
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LargerThanNeighbours
{
    static bool LargerThenNeighbors(int[] arr, int index)
    {
        if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
        {
            return true;
        }

        return false;
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

        Console.WriteLine("Enter number of the position you want to check( dont choose edge elements):");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Is this element larger then its neighbors? -> {0}", LargerThenNeighbors(array, k));
    }
}
