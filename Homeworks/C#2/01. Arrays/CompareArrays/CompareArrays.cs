//Task 2
//Write a program that reads two integer arrays from the console and compares them element by element
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class CompareArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter first array length number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstNumber];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter second array length number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int[] secondArray = new int[secondNumber];
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool areSame = false;

            if (firstNumber != secondNumber)
            {
                Console.WriteLine("Arrays are same --> {0}", areSame);
                return;
            }

            for (int i = 0, j = 0; i < firstArray.Length; i++, j++)
            {
                if (firstArray[i] != secondArray[j])
                {
                    Console.WriteLine("Arrays are same --> {0}", areSame);
                    return;
                }
            }

            areSame = true;
            Console.WriteLine("Arrays are same --> {0}", areSame);
        }
    }
