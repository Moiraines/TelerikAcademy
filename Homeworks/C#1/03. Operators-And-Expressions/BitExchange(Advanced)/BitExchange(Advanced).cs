//Task 16
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:

//n	p	q	k	binary representation of n	binary result	result
//1140867093	3	24	3	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
//4294901775	24	3	3	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
//2369124121	2	22	10	10001101 00110101 11110111 00011001	01110001 10110101 11111000 11010001	1907751121
//987654321	2	8	11	00111010 11011110 01101000 10110001	-	overlapping
//123456789	26	0	7	00000111 01011011 11001101 00010101	-	out of range
//33333333333	-1	0	33	00000111 11000010 11010010 01001101 01010101	-	out of range
using System;
    class BitExchange_Advanced_
    {
        static void Main()
        {

            Console.WriteLine("Enter n number: ");
            uint num = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter p number: ");
            byte p = byte.Parse(Console.ReadLine());
            if (p < 0 || p > 31)
            {
                Console.WriteLine("Invalid number.Try again:\n");
                return;
            }

            Console.WriteLine("Enter q number: ");
            byte q = byte.Parse(Console.ReadLine());
            if (q < 0 || q > 31)
            {
                Console.WriteLine("Invalid number.Try again:\n");
                return;
            }

            Console.WriteLine("Enter k number: ");
            byte k = byte.Parse(Console.ReadLine());


            if (Math.Max(p, q) + k > 32 || Math.Min(p, q) < 0 || Math.Max(p, q) > 31)
            {
                Console.WriteLine("out of range");
                return;
            }

            if (Math.Abs(q - p) < k)
            {
                Console.WriteLine("overlapping");
                return;
            }

            for (byte i = 0; i < k; i++)
            {
                num = BitExchange(num, p + i, q + i);
            }

            Console.WriteLine("Binary result: {0}\nResult: {1}", Convert.ToString(num, 2).PadLeft(32, '0'), num);

        }

        static uint BitExchange(uint num, int p, int q)
        {
            uint shiftNumP = num >> p;
            byte bitP = (byte)(shiftNumP & 1);
            uint shiftNumQ = num >> q;
            byte bitQ = (byte)(shiftNumQ & 1);

            //change bit P
            if (bitP == 0)
            {
                uint maskP = (uint)~(1 << q);
                num = num & maskP;
            }
            else
            {
                uint maskP = (uint)(1 << q);
                num = num | maskP;
            }

            //change bit Q
            if (bitQ == 0)
            {
                uint maskQ = (uint)~(1 << p);
                num = num & maskQ;
            }
            else
            {
                uint maskQ = (uint)1 << p;
                num = num | maskQ;
            }

            return num;
        }
    }
