namespace Problem07
{
    using System;
    using System.Collections.Generic;

    /*Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.

         Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
         2 → 2 times
         3 → 4 times
         4 → 3 times*/
    public class StartUp
    {
        public static void Main()
        {
            var inputList = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var occurs = new Dictionary<int, int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (!occurs.ContainsKey(inputList[i]))
                {
                    occurs.Add(inputList[i], 1);
                }
                else
                {
                    occurs[inputList[i]]++;
                }
            }

            Console.WriteLine("Result: ");

            foreach (KeyValuePair<int,int> pair in occurs)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
