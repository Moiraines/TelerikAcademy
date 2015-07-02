//Task 15
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class NumberCalculations
    {
        static T Minimum<T>(params T[] arr)
        {
            Array.Sort(arr);

            return arr[0];
        }

        static T Maximum<T>(params T[] arr)
        {
            Array.Sort(arr);

            return arr[arr.Length];
        }

        static T Average<T>(params T[] arr)
        {
            dynamic sumAvg = Sum(arr) / (dynamic)arr.Length; ;
            return sumAvg;
        }

        static T Sum<T>(params T[] arr)
        {
            dynamic sum = 0L;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static T Product<T>(params T[] arr)
        {
            dynamic product = 1L;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static void Main()
        {
            Console.WriteLine("Your example sequence is \"2, 3, -6, -1, 2, -1, 6, 4, -8, 8\"");
            string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";
            string[] splitedString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            dynamic[] array = new dynamic[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = splitedString[i];
            }

            Console.WriteLine("Minimum: {0}", Minimum(array));
            Console.WriteLine("Maximum: {0}", Maximum(array));
            Console.WriteLine("Average: {0}", Average(array));
            Console.WriteLine("Sum: {0}", Sum(array));
            Console.WriteLine("Product: {0}", Product(array));
        }
    }
