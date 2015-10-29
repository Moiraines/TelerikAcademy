using System;
using System.Collections.Generic;

namespace Problem04
{
    /*Write a method that finds the longest subsequence of equal numbers in given List and returns the result as 
    new List<int>.
            -Write a program to test whether the method works correctly.*/
    public class StartUp
    {
        public static void Main()
        {
            //Test 1
            Console.WriteLine("Test 1: Sequence [2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
            var checkList = new List<int>() { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            Console.WriteLine("Expected maximal subsequence -> 2, 2, 2");
            FindLongestSubsequence(checkList);

            //Test 2
            Console.WriteLine("\nTest 2: Sequence [4, 4, 7, 7, 7, 3, 16, -10, 25, 1]");
            checkList = new List<int>() { 4, 4, 7, 7, 7, 3, 16, -10, 25, 1 };
            Console.WriteLine("Expected maximal subsequence -> 7, 7, 7");
            FindLongestSubsequence(checkList);

            //Test 3
            Console.WriteLine("\nTest 3: Sequence [0, -20, 17, 102, 3, 100, 7, 33, 33, 1]");
            checkList = new List<int>() { 0, -20, 17, 102, 3, 100, 7, 33, 33, 1 };
            Console.WriteLine("Expected maximal subsequence -> 33, 33");
            FindLongestSubsequence(checkList);

        }

        private static void FindLongestSubsequence(List<int> list)
        {

            int counter = 1;
            int maxSequence = 0;
            int sequenceStart = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                {
                    if (list[i] != list[i - 1])
                    {
                        counter = 1;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        sequenceStart = i + 1 - maxSequence;
                    }
                }
            }

            Print(list, maxSequence, sequenceStart);
        } 

        private static void Print(List<int> list, int maxSequence, int sequenceStart)
        {
            Console.WriteLine("Result Maximal Subsequence: ");
            for (int i = sequenceStart; i < sequenceStart + maxSequence; i++)
            {
                if (i == sequenceStart + maxSequence - 1)
                {
                    Console.Write("{0}", list[i]);
                    break;
                }
                Console.Write("{0}, ", list[i]);
            }
            Console.WriteLine();

        }
    }
}
