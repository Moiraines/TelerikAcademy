//Task 6
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;
    class QuadraticEquation
    {
        static void Main()
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Enter \"a\" number: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter \"b\" number: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter \"c\" number: ");
            c = double.Parse(Console.ReadLine());

            double dis = (b * b) - (4 * a * c);
            double x1 = (-b - Math.Sqrt(dis)) / (2 * a);
            double x2 = (-b + Math.Sqrt(dis)) / (2 * a);

            if (dis > 0)
                {  
                    Console.WriteLine();
                    Console.WriteLine("x1={0}; x2={1}", x1, x2);
                }

            if (dis == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("x1=x2={0}", x1);
                }

            if (dis < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("no real roots");
                }

        }
    }
