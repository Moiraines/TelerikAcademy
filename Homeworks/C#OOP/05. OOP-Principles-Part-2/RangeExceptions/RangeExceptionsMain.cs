//Task 3
//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;

    class RangeExceptionsMain
    {
        static void Main()
        {
            // test with int parameter
            var testNumbers = new List<int>{ 70, 120 };

            foreach (int number in testNumbers)
            {
                try
                {
                    if (number < 0 || number > 100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }
                    Console.WriteLine("{0} is in the allowed range", number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("{0}: {1}", number, ex.Message);
                }
            }

            //test with DateTime parameter

            var testDates = new List<DateTime> { new DateTime(2000, 6, 16), DateTime.Now };
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31, 23, 59, 59);

            foreach (var date in testDates)
            {
                try
                {
                    if (date < startDate || date > endDate)
                    {
                        throw new InvalidRangeException<DateTime>(startDate, endDate);
                    }
                    Console.WriteLine("{0} is in the allowed range", date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("{0}: {1}", date, ex.Message);
                }
            }
        }
    }
}
