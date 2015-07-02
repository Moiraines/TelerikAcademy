//Task 3
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
using System;
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool divideCheck = ((number % 5 == 0) && (number % 7 == 0));

            Console.WriteLine("Can the number be divided by 5 and 7 at the same time? {0}", divideCheck);

            //    Second WAY
            //    Console.WriteLine("Please enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    bool divideCheck = false;
            //    if ((number % 5 == 0) && (number % 7 == 0))
            //        {
            //            divideCheck = true;
            //        }
            //        Console.WriteLine("Can the number be divided by 5 and 7 at the same time? {0}", divideCheck);
        }
    }
