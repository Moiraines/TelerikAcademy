namespace Problem03
{
    using System;
    using System.Collections.Generic;

    /*Write a program that reads a sequence of integers (List<int>) ending with an empty line 
    and sorts them in an increasing order.*/

    public class StartUp
    {
        public static void Main()
        {
            var sequence = new List<int>();
            int currentNumber;

            Console.WriteLine("Please enter the sequence of numbers each on new line and end the sequence with empty line:");
            string inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                currentNumber = int.Parse(inputLine);
                sequence.Add(currentNumber);
                inputLine = Console.ReadLine();
            }

            sequence.Sort();

            Console.WriteLine("Sorted numbers:");
            foreach (var number in sequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
