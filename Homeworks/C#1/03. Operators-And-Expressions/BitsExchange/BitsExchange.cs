//Task 15
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint n;

            Console.WriteLine("Enter an integer number: ");
            bool correctNumber = uint.TryParse(Console.ReadLine(), out n);
            while (!correctNumber)
            {
                Console.WriteLine("Wrong number format.\nTry again: ");
                correctNumber = uint.TryParse(Console.ReadLine(), out n);
            }

            uint mask = 1 << 3;
            uint nAndMask = n & mask;
            uint bit3 = nAndMask >> 3;
            mask = 1 << 24;
            nAndMask = n & mask;
            uint bit24 = nAndMask >> 24;
            mask = 1 << 4;
            nAndMask = n & mask;
            uint bit4 = nAndMask >> 4;
            mask = 1 << 25;
            nAndMask = n & mask;
            uint bit25 = nAndMask >> 25;
            mask = 1 << 5;
            nAndMask = n & mask;
            uint bit5 = nAndMask >> 5;
            mask = 1 << 26;
            nAndMask = n & mask;
            uint bit26 = nAndMask >> 26;

            uint maskSwap3To24;
            uint tempNew1Iter;
            bool bitValue1 = (bit3 == 1);
            if (bitValue1)
                {
                    maskSwap3To24 = 1 << 24;
                    tempNew1Iter = maskSwap3To24 | n;
                }
            else
                {
                    maskSwap3To24 = ~(uint)(1 << 24);
                    tempNew1Iter = maskSwap3To24 & n;
                }

            uint maskSwap24To3;
            uint tempNew2Iter;
            bool bitValue2 = (bit24 == 1);
            if (bitValue2)
                {
                    maskSwap24To3 = 1 << 3;
                    tempNew2Iter = maskSwap24To3 | tempNew1Iter;
                }
            else
                {
                    maskSwap24To3 = ~(uint)(1 << 3);
                    tempNew2Iter = maskSwap24To3 & tempNew1Iter;
                }

            uint maskSwap4To25;
            uint tempNew3Iter;
            bool bitValue3 = (bit4 == 1);
            if (bitValue3)
                {
                    maskSwap4To25 = 1 << 25;
                    tempNew3Iter = maskSwap4To25 | tempNew2Iter;
                }
            else
                {
                    maskSwap4To25 = ~(uint)(1 << 25);
                    tempNew3Iter = maskSwap4To25 & tempNew2Iter;
                }

            uint maskSwap25To4;
            uint tempNew4Iter;
            bool bitValue4 = (bit25 == 1);
            if (bitValue4)
                {
                    maskSwap25To4 = 1 << 4;
                    tempNew4Iter = maskSwap25To4 | tempNew3Iter;
                }
            else
                {
                    maskSwap25To4 = ~(uint)(1 << 4);
                    tempNew4Iter = maskSwap25To4 & tempNew3Iter;
                }

            uint maskSwap5To26;
            uint tempNew5Iter;
            bool bitValue5 = (bit5 == 1);
            if (bitValue5)
                {
                    maskSwap5To26 = 1 << 26;
                    tempNew5Iter = maskSwap5To26 | tempNew4Iter;
                }
            else
                {
                    maskSwap5To26 = ~(uint)(1 << 26);
                    tempNew5Iter = maskSwap5To26 & tempNew4Iter;
                }

            uint maskSwap26To5;
            uint tempNew6Iter;
            bool bitValue6 = (bit26 == 1);
            if (bitValue6)
                {
                    maskSwap26To5 = 1 << 5;
                    tempNew6Iter = maskSwap26To5 | tempNew5Iter;
                }
            else
                {
                    maskSwap26To5 = ~(uint)(1 << 5);
                    tempNew6Iter = maskSwap26To5 & tempNew5Iter;
                }

            uint finalNumber = tempNew6Iter;

            Console.WriteLine("Binary result: {0}\nResult: {1}", Convert.ToString(finalNumber, 2).PadLeft(32, '0'), finalNumber);




        }
    }
