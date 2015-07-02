//Task 6
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class MaximalKSum
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
            Console.WriteLine("Enter k value: ");
            int k = int.Parse(Console.ReadLine());
            while (k>=n)
            {
                Console.WriteLine("K have to be lower then array's length.\nPlease try again: ");
                k = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The subset with maximum sum is: ");
            Array.Sort(myArray);
            int sum = 0;

            for (int index = myArray.Length - 1; index > myArray.Length - 1 - k; index--)
            {
                sum += myArray[index];
                Console.Write("{0} + ", myArray[index]);
            }
            Console.WriteLine("= {0}", sum);
        }
    }
