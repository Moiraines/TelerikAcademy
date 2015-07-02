//Task 2
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class EnterNumbers
    {
        static int ReadNumbers(int start, int end)
        {
            Console.WriteLine("Enter the number between {0} and {1}", start, end);
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number; 
        }

        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            for (int i = 1; i < 11; i++)
            {
                try
                {
                    start = ReadNumbers(start, end);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (ArgumentOutOfRangeException ie)
                {
                    Console.WriteLine("Error " + ie.Message);
                }
                catch (OverflowException of)
                {
                    Console.WriteLine("Error " + of.Message);
                }
            }
            
        }
    }
