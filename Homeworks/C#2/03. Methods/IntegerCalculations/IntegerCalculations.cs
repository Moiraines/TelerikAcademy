//Task 14
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class IntegerCalculations
    {
        static long Minimum(long [] arr)
        {
            Array.Sort(arr);

            return arr[0];
        }

        static long Maximum(long[] arr)
        {
            Array.Sort(arr);

            return arr[arr.Length];
        }

        static double Average(long[] arr)
        {
            double sumAvg = Sum(arr) / (double)arr.Length;;
            return sumAvg;
        }

        static long Sum(long[] arr)
        {
            long sum = 0L;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static long Product(long[] arr)
        {
            long product = 1L;
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
            long[] array = new long[splitedString.Length];
            for (int i = 0; i < splitedString.Length; i++)
            {
                array[i] = long.Parse(splitedString[i]);
            }

            Console.WriteLine("Minimum: {0}", Minimum(array));
            Console.WriteLine("Maximum: {0}", Maximum(array));
            Console.WriteLine("Average: {0}", Average(array));
            Console.WriteLine("Sum: {0}", Sum(array));
            Console.WriteLine("Product: {0}", Product(array));
        }
    }
