//Task 10
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
using System;
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');

            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < strArr.Length; i++)
            {
                int num = int.Parse(strArr[i]);

                if (i % 2 == 0)
                {
                    oddProduct *= num;
                }
                else
                {
                    evenProduct *= num;
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
