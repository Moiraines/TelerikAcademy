//Task 12
//Create a program that assigns null values to an integer and to a double variable.Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
using System;
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a + 1);
            Console.WriteLine(b + null);
        }
    }
