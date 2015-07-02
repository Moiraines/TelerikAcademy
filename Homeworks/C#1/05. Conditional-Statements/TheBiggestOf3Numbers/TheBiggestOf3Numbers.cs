//Task 5
//Write a program that finds the biggest of three numbers.
//Examples:

//a	    b	   c	    biggest
//5	    2	    2	    5
//-2	-2	    1	    1
//-2	4	    3	    4
//0	    -2.5	5	    5
//-0.1	-0.5	-1.1	-0.1
using System;
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter \"a\" number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"c\" number:");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Biggest number is: {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Biggest number is: {0}", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Biggest number is {0}", c);
            }
        }
    }
