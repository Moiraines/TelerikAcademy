namespace Problem02
{
    using System;
    using System.Collections.Generic;

    /*Write a program that reads N integers from the console and reverses them using a stack.
        -Use the Stack<int> class.*/
    public class StartUp
    {
        public static void Main()
        {
            var sequence = new Stack<int>();
            int currentNumber;

            Console.WriteLine("Please enter the sequence of numbers each on new line and end the sequence with empty line:");
            string inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                currentNumber = int.Parse(inputLine);
                sequence.Push(currentNumber);
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Reversed sequence:");
            while (sequence.Count != 0)
            {
                Console.WriteLine(sequence.Pop());
            }
        }
    }
}
