//Task 12
//Write an expression that extracts from given integer n the value of given bit at index p.
using System;
    class ExtractBitFromInteger
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

            Console.WriteLine("Enter a bit position you want to see(between 0 and 31): ");
            correctNumber = sbyte.TryParse(Console.ReadLine(), out p);
            while (!correctNumber || p < 0 || p > 31)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = sbyte.TryParse(Console.ReadLine(), out p);
                }

            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine("bit #" + p + " of your number is: {0}", bit);
        }
    }
