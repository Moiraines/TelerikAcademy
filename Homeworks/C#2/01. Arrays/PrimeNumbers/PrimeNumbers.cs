//Task 15
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class PrimeNumbers
    {
        static void Main()
        {
            int n = 10000000;
            int[] arr = new int[n];

            //fill the array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            //find prime numbers via Sieve of Eratosthenes algorithm
            // Warning: the console output should take some time :) If you want to check some lower numbers change n to lower value.
            for (int i = 1; i < arr.Length; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }

                    if (arr[i] % 3 == 0)
                    {
                        continue;
                    }

                    if (arr[i] % 5 == 0)
                    {
                        continue;
                    }

                    if (arr[i] % 7 == 0)
                    {
                        continue;
                    }

                    Console.Write(arr[i] + ", ");
                }  
            }
            Console.WriteLine();
        }
    }
