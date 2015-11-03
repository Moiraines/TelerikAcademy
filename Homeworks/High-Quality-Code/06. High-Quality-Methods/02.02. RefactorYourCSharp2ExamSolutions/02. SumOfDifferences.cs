////Task Description is in its respected file in same project
namespace ExamCSharp2Task2 
{
    using System;
    using System.Numerics;

    public class CalculateDifferences
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            string[] splited = input.Split(' ');
            BigInteger SumOfAbsoluteEvenDifferences = 0;
            long absoluteDifference;

            for (int i = 1; i < splited.Length; i++)
            {
                absoluteDifference = Math.Abs(long.Parse(splited[i]) - long.Parse(splited[i - 1]));

                if (absoluteDifference % 2 != 0)
                {
                    SumOfAbsoluteEvenDifferences += absoluteDifference;
                }
                else if (absoluteDifference % 2 == 0 && i == splited.Length - 2)
                {
                    break;
                }
                else if (absoluteDifference % 2 == 0 && i < splited.Length - 2)
                {
                    i++;
                }

                absoluteDifference = 0;
            }

            Console.WriteLine(SumOfAbsoluteEvenDifferences);
        }
    }
}