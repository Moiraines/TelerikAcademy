namespace Problem_02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
    Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. 
    Example:

    {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    */
    public class StartUp
    {
        static void Main()
        {
            var inputList = new List<string>() {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var occurs = new Dictionary<string, int>();

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

            foreach (KeyValuePair<string, int> pair in occurs.Where(x => x.Value % 2 != 0))
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
