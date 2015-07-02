//Task 10
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array	                S	result
//4, 3, 1, 4, 2, 5, 8	11	4, 2, 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class FindSumInArray
    {
        static void Main()
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "4, 3, 1, 4, 2, 5, 8";
            
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            Console.WriteLine("Enter a sum: ");
            int s = int.Parse(Console.ReadLine());
            //int s = 11;
            int tempSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    tempSum += array[j];
                    if (tempSum == s)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(array[k] + (k!=j?", ":""));
                        }
                        Console.WriteLine();
                    }
                    else if (tempSum > s)
                    {
                        break;
                    }
                }
                tempSum = 0;
            }
        }
    }
