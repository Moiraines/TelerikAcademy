namespace Problem05
{
    using System;
    using System.Collections.Generic;

    /*Write a program that removes from given sequence all negative numbers.*/

    public class StartUp
    {
        public static void Main()
        {
            var checkList = new List<int>() { 2, -10, 1, 2, -3, 3, 2, -2, 5, 1 };

            var purifiedList = checkList.FindAll(n => n > 0);

            Console.WriteLine("Output list after negative number removal: ");
            foreach (var number in purifiedList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
