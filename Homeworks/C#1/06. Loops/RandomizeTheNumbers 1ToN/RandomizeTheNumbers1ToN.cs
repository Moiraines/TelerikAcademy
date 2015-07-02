//Task 12
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;
    class RandomizeTheNumbers1ToN
    {
        static void Main()
        {
            int n;

            Console.WriteLine("Enter number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out n);
            while (!correctNumber || n <= 0)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = int.TryParse(Console.ReadLine(), out n);
            }

            int[] array = new int[n];
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
            array = randomized(array);

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }   
            
        }

        public static int[] randomized(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = rand.Next(i);
                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }
    }
