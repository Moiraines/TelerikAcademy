//Task 4
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class BinarySearch
    {
        static void Main()
        {
            // enter the array in a form like the commented example below
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            Array.Sort(array);
            int result = Array.BinarySearch(array, k);

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            if (result < -1)
            {
                Console.WriteLine("Largest number lower than or equal to {0} is {1}", k, array[~result - 1]);
            }
            else if (~result == 0)
            {
                Console.WriteLine("No such number");
            }
            else
            {
                Console.WriteLine("Largest number lower than or equal to {0} is {1}", k, array[result]);
            }
            

        }

    }
