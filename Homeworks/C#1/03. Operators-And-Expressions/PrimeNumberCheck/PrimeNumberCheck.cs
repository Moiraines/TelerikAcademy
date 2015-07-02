//Task 8
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            uint number;
            bool correctNumber = uint.TryParse(Console.ReadLine(), out number);
            while (!correctNumber)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = uint.TryParse(Console.ReadLine(), out number);
                }
            bool isPrime = true;

            if (number == 1 || number == 0)
                {
                    Console.WriteLine(number + " is not prime number");
                }
            else
                {
                    for (uint i = 2; i <= number / 2; i++)
                        {
                            if (number % i == 0)
                            {
                                Console.WriteLine(number + " is not prime number");
                                return;
                            }
                        
                        }
                    Console.WriteLine(number + " is a prime number");
                }
            
        }  
                     
    }
