namespace Problem06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*Write a program that removes from given sequence all numbers that occur odd number of times.

        Example:
        {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}*/

    public class StartUp
    {
        public static void Main()
        {
            var inputList = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
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
            foreach (int element in inputList.Where(x => occurs[x] % 2 == 0))
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
