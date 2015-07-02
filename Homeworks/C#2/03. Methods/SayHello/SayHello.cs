﻿//Task 1
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:
//input	    output
//Peter	    Hello, Peter!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SayHello
    {
        static void PrintName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            PrintName();
        }
    }
