//Task 14
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
using System;
class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            int n;
            sbyte p;
            sbyte v;

            Console.WriteLine("Enter an integer number: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out n);
            while (!correctNumber)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out n);
                }

            Console.WriteLine("Enter a bit position you want to see(between 0 and 31): ");
            bool correctPositionNumber = sbyte.TryParse(Console.ReadLine(), out p);
                while (!correctNumber || p < 0 || p > 31)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = sbyte.TryParse(Console.ReadLine(), out p);
                }

            Console.WriteLine("Enter a bit value(between 0 and 1): ");
            bool correctBitValue = sbyte.TryParse(Console.ReadLine(), out v);
            while (!correctNumber || v < 0 || v > 1)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctBitValue = sbyte.TryParse(Console.ReadLine(), out v);
                }
            int mask;
            int newN;
            bool bitValue = (v == 1);
            if (bitValue)
                {
                    mask = 1 << p;
                    newN = mask | n;
                }
            else
                {
                    mask = ~(1 << p);
                    newN = mask & n;
                }
            Console.WriteLine("Binary result: {0}\nResult: {1}", Convert.ToString(newN, 2).PadLeft(16, '0'), newN);
        }
    }
