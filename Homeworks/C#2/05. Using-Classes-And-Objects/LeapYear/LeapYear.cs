//Task 1
//Write a program that reads a year from the console and check whether it is a leap one
//Use System.DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter an year: ");
            int year = int.Parse(Console.ReadLine());            
            Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
        }
    }
