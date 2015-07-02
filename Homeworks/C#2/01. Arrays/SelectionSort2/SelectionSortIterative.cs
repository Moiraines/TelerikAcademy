//Task 7
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SelectionSortIterative
    {
        static void Main()
        {
            Console.WriteLine("Enter an array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int minimal;

            for (int i = 0; i < myArray.Length; i++)
            {
                minimal = i;

                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[minimal] > myArray[j])
                    {
                        minimal = j;
                    }
                }
                //swap part
                if (i != minimal)
                {
                    myArray[i] += myArray[minimal];
                    myArray[minimal] = myArray[i] - myArray[minimal];
                    myArray[i] -= myArray[minimal];
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0}, ", myArray[i]);
            }
        }
    }
