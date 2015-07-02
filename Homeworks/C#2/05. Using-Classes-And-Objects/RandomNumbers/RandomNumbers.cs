//Task 2
//Write a program that generates and prints to the console 10 random  values in the range
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class RandomNumbers
    {
        static void Main()
        {
            Random randomGenerator = new Random();

            for (int i = 1; i <= 10; i++)
            {
                int randomNumber = randomGenerator.Next(100, 201);
                Console.Write("{0} ", randomNumber);
            }
        }
    }
