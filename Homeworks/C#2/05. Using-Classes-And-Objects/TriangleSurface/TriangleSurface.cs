//Task 4
//Write method that calculate the surface of a triangle by given:
//Side and altitude to it;
//Three sides;
//Two Sides and an angel between them;
//Use System.Math.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("Choose an option between a, b or c");
            string option = Console.ReadLine();
            double result = 0.0;

            switch (option)
            {
                case "a":
                    {
                        Console.WriteLine("Enter number for side:");
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number for altitude:");
                        double altitude = double.Parse(Console.ReadLine());
                        result = 0.5 * side * altitude;
                    }
                    break;
                case "b":
                    {
                        double[] arr = new double[4];
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine("Enter number for side {0}:", i);
                            arr[i - 1] = double.Parse(Console.ReadLine());
                        }
                        double p = 0.5 * (arr[0] + arr[1] + arr[2]);
                        result = Math.Sqrt(p * (p - arr[0]) * (p - arr[1]) * (p - arr[2]));
                    }
                    break;
                case "c":
                    {
                        Console.WriteLine("Enter number for side A:");
                        double sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number for side B:");
                        double sideB = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a number for angle degrees between 0 and 180 degrees:");
                        double angle = double.Parse(Console.ReadLine());
                        //Math.Sin uses radians, so we need to convert degrees to radians via Math.PI/180.
                        result = 0.5 * sideA * sideB * Math.Sin(angle* Math.PI/180);

                    }
                    break;
                default:
                    {
                        while (option != "a" && option != "b" && option != "c" && option != "d")
                        {
                            Console.WriteLine("Invalid choice\nTry again: ");
                            option = Console.ReadLine();
                        }
                    }
                    break;
            }

            Console.WriteLine("The Square of the triangle is:\n{0}", result);
        }
    }
}
