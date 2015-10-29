namespace Problem01
{
    using System;
    using System.Collections.Generic;


    /*Write a program that reads from the console a sequence of positive integer numbers.
        -The sequence ends when empty line is entered.
        -Calculate and print the sum and average of the elements of the sequence.
        -Keep the sequence in List<int>.*/
    public class StartUp
    {
        public static void Main()
        {
            var sequence = new List<int>();
            int sum = 0;
            int currentNumber;

            Console.WriteLine("Please enter the sequence of numbers each on new line and end the sequence with empty line:");
            string inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                currentNumber = int.Parse(inputLine);
                sequence.Add(currentNumber);
                sum += currentNumber;
                inputLine = Console.ReadLine();
            }

            int average = sum/sequence.Count;

            Console.WriteLine("Sum of the sequence is: {0}, average is: {1}", sum, average);
        }
    }
}
