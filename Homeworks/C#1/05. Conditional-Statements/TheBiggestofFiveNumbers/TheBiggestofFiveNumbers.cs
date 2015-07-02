//Task 6
//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:

//a	b	c	d	e	biggest
//5	2	2	4	1	5
//-2	-22	1	0	0	1
//-2	4	3	2	0	4
//0	-2.5	0	5	5	5
//-3	-0.5	-1.1	-2	-0.1	-0.1
using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter \"a\" number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"c\" number:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"d\" number:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"e\" number:");
            double e = double.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("Biggest number is {0}", a);
            }
            else
            {
                if (b > c && b > d && b > e)
                {
                    Console.WriteLine("Biggest number is {0}", b);
                }
                else
                {
                    if (c > d && c > e)
                    {
                        Console.WriteLine("Biggest number is {0}", c);
                    }
                    else
                    {
                        if (d > e)
                        {
                            Console.WriteLine("Biggest number is {0}", d);
                        }
                        else
                        {
                            Console.WriteLine("Biggest number is {0}", e);
                        }
                    }
                }
            }
        }
    }

