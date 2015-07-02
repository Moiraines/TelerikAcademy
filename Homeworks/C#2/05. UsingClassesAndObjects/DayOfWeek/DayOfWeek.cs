//Task 3
//Write a program that prints to the console which day of the week is today.
//use System.DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime current = DateTime.Now;

            Console.WriteLine(current.DayOfWeek);
        }
    }
}
