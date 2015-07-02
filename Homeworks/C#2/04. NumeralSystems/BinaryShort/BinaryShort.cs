//Task 8
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class BinaryShort
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number in [-32,768; 32,767):");
            short number = short.Parse(Console.ReadLine());
            string numberBinary = null;
            if (number >= 0)
            {
                numberBinary = DecimalToBinary(number, numberBinary);
                Console.WriteLine();
                Console.WriteLine("Result: ");
                Console.WriteLine(numberBinary.PadLeft(32, '0'));
            }
            else
            {
                number = (short)((short.MinValue - number)*(-1));
                numberBinary = DecimalToBinary(number, numberBinary);
                string result = numberBinary.PadLeft(32, '0');
                int[] arr = new int[32];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = result[i] - '0';
                }

                arr[0] = 1;
                Console.WriteLine("Result: {0}", String.Join("", arr));

            }
        }

        static string DecimalToBinary(short number, string numberBinary)
        {
            if (number == 0)
            {
                numberBinary = "0";
                return numberBinary;
            }
            else
            {
                while (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        numberBinary = "0" + numberBinary;
                    }
                    else
                    {
                        numberBinary = "1" + numberBinary;
                    }
                    number /= 2;
                }
                return numberBinary;
            }
        }
    }
