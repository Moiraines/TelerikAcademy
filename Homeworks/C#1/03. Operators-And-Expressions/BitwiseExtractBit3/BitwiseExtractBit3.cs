//Task 11
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
using System;
    class BitwiseExtractBit3
    {
        static void Main()
        {
            uint number;
            Console.WriteLine("Enter a positive integer number: ");
            bool correctNumber = uint.TryParse(Console.ReadLine(), out number);
            while (!correctNumber || number < 0)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = uint.TryParse(Console.ReadLine(), out number);
                }
            uint mask = 1 << 3;
            uint nAndMask = number & mask;
            uint bit = nAndMask >> 3;
            Console.WriteLine("bit #3 of your number is: {0}", bit);
        }
    }
