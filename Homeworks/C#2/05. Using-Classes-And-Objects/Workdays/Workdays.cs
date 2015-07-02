//Task 5
//Write a method that calculates the number of workdays between today and given date, passed as paramater.
//Consider that workdays are all days from Monday to Friday except a fixed list of holidays specified preliminary as array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
    class Workdays
    {
        static List<DateTime> holidaysList;
        static void Main()
        {
            CultureInfo MyCultureInfo = new CultureInfo("en-US");
            DateTime startDate = DateTime.Now;
            Console.WriteLine("Enter a end date in format MM/DD/YYYY:");
            DateTime endDate = DateTime.Parse(Console.ReadLine());


             holidaysList = new List<DateTime>()
            {
                new DateTime(2015, 3, 3),
                new DateTime(2015, 4, 10),
                new DateTime(2015, 4, 13),
                new DateTime(2015, 5, 6),
                new DateTime(2015, 9, 22),
                new DateTime(2015, 12, 24),
                new DateTime(2015, 12, 25)
            };
            int workDays = CountWorkdays(new DateTime(startDate.Year, startDate.Month, startDate.Day), new DateTime(endDate.Year, endDate.Month, endDate.Day));

            Console.WriteLine("The result for Workdays is: {0}", workDays);
        }

        static int CountWorkdays(DateTime startDate, DateTime endDate)
        {
            int workDays = 0;

            while (startDate <= endDate)
            {
                if (!holidaysList.Contains(startDate) && (int)startDate.DayOfWeek != 0 && (int)startDate.DayOfWeek != 6)
                {
                    workDays++;
                }

                startDate = startDate.AddDays(1);
            }

            return workDays;
        }
    }
