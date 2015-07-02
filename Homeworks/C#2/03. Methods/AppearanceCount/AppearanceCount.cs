//Task 4
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class AppearanceCount
    {
        static int NumberCheckCounter(int[] arr, int k)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            Console.WriteLine("Enter input like the commented example: ");
            string input = Console.ReadLine();
            //string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = int.Parse(splitedString[i]);
            }

            Console.WriteLine("Enter a number you want to check:");
            int k = int.Parse(Console.ReadLine());

            int result = NumberCheckCounter(array, k);
            Console.Write("Your number appears ");
            Console.WriteLine(result + " " + (result == 1?"time":"times"));
        }
    }
