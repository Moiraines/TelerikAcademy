//Task 13
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
using System;
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            int n;
            sbyte p;

            Console.WriteLine("Enter an integer number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out n);
            while (!correctNumber)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out n);
                }

            Console.WriteLine("Enter a bit position you want to check(between 0 and 31): ");
            correctNumber = sbyte.TryParse(Console.ReadLine(), out p);
            while (!correctNumber || p < 0 || p > 31)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = sbyte.TryParse(Console.ReadLine(), out p);
                }

            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            bool bitValue = (bit == 1);
            Console.WriteLine("The Result is {0}", bitValue);
        }
    }
