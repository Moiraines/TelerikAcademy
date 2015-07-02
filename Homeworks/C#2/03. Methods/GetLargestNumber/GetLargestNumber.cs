//Task 2
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class GetLargestNumber
    {
        static void Main()
        {
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\nEnter " + (i + 1).ToString() + " number:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = CompareNumbers(arr[0], arr[1]);
            int finalResult = CompareNumbers(arr[2], result);
            Console.WriteLine("Largest number is {0}:", finalResult);
        }

        static int CompareNumbers(int a, int b)
        {
            int max = a;
            if (b > a)
            {
                max = b;
            }

            return max;
        }
    }
