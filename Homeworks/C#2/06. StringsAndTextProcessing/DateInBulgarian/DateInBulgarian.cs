//Task 17
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
    class DateInBulgarian
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(@"Enter date in format ""day.month.year hour:minute:second"":");
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d.M.yyyy H:m:s", CultureInfo.GetCultureInfo("bg-BG"));

            DateTime newDate = date.AddMinutes(390);

            Console.WriteLine("Result:\n{0:dd.MM.yyyy HH:mm:ss dddd}", newDate);


        }
    }
