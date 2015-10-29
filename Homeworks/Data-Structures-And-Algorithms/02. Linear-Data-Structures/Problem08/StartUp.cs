using System.Linq;

namespace Problem08
{
    using System;
    using System.Collections.Generic;

    /**The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

        Write a program to find the majorant of given array (if exists).
        Example:
        {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3*/
    public class StartUp
    {
        static void Main()
        {
            var inputList = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
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

            
            int maxOccurs = 0;

            foreach (KeyValuePair<int, int> pair in occurs)
            {
                if (pair.Value > maxOccurs)
                {
                    maxOccurs = pair.Value;
                }
            }

            var myValue = occurs.FirstOrDefault(x => x.Value == maxOccurs).Key;
            Console.WriteLine("Result: ");
            Console.WriteLine(myValue);
        }
    }
}
