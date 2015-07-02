//Task 1
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            try
            {
                ulong number = ulong.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
