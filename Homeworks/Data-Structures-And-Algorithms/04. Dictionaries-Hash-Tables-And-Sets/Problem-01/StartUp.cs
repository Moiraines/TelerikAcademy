namespace Problem_01
{
    using System;
    using System.Collections.Generic;

    /*
    Write a program that counts in a given array of double values the number of occurrences of each value. 
    Use Dictionary<TKey,TValue>.

    Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
    -2.5 -> 2 times
    3 -> 4 times
    4 -> 3 times
    */
    public class StartUp
    {
        public static void Main()
        {
            var example = new double[] {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5};
            Array.Sort(example);
            var occurs = new Dictionary<double, int>();

            for (int i = 0; i < example.Length; i++)
            {
                if (!occurs.ContainsKey(example[i]))
                {
                    occurs.Add(example[i], 1);
                }
                else
                {
                    occurs[example[i]]++;
                }
            }

            Console.WriteLine("Result: ");

            foreach (KeyValuePair<double, int> pair in occurs)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }

        }
    }
}
