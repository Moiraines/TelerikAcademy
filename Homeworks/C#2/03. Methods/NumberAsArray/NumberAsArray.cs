//Task 8
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class NumberAsArray
    {
        static int carrier = 0;
        static int[] SumOfNumbers(int[] arr1, int[] arr2)
        {
            int max = arr1.Length;
            if (arr1.Length < arr2.Length)
            {
                max = arr2.Length;
            }
            int[] arrSum = new int[max];
            for (int i = 0; i < max; i++)
			{

                arrSum[i] = carrier;
                if (i == arr1.Length)
                {
                    for (int j = arr1.Length; j < arr2.Length; j++)
                    {
                        arrSum[j] = arr2[j];
                    }
                    break;
                }

                if (i == arr2.Length)
                {
                    for (int j = arr2.Length; j < arr1.Length; j++)
                    {
                        arrSum[j] = arr1[j];
                    }
                    break;
                }

                if (arr1[i] + arr2[i] > 9)
	            {
                    arrSum[i] += (arr1[i] + arr2[i]) % 10;
                    carrier = (arr1[i] + arr2[i]) / 10;
	            }
                else
	            {
                    arrSum[i] += (arr1[i] + arr2[i]);
                    carrier = 0;
	            }
                
			}
            return arrSum;
        }
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string number2 = Console.ReadLine();
            //string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";

            int[] array1 = new int[number1.Length];
            int[] array2 = new int[number2.Length];
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                array1[i] = number1[array1.Length - 1 - i] - '0';
            }
            for (int j = array2.Length - 1; j >= 0; j--)
            {
                array2[j] = number2[array2.Length - 1 - j] - '0';
            }

            int[] arrayResult = SumOfNumbers(array1, array2);


                Array.Reverse(arrayResult);
                if (carrier == 0)
                {
                    Console.WriteLine("The sum of the numbers is:\n{0}", String.Join("", arrayResult)); 
                }
                else
                {
                    Console.WriteLine("The sum of the numbers is:\n1{0}", String.Join("", arrayResult));
                }
                
            
        }
    }
