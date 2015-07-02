//Task 3
//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter first array length number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            char[] firstArray = new char[firstNumber];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter second array length number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            char[] secondArray = new char[secondNumber];
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                secondArray[i] = char.Parse(Console.ReadLine());
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
