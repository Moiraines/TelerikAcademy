//Task 16
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
    class DateDifference
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter the first date:");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second date:");
            string second = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(first, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(second, "d.MM.yyyy", CultureInfo.InvariantCulture);

            int daysCounter = 0;

            while (firstDate < secondDate)
            {
                daysCounter++;
                firstDate = firstDate.AddDays(1);
            }

            Console.WriteLine();
            Console.WriteLine("Distance: {0} days", daysCounter);
        }
    }
