////Task Description is in its respected file in same project
namespace ExamCSharp1Task1
{
    using System;

    public class PrintSum
    {
        public static void Main()
        {
            long students = int.Parse(Console.ReadLine());
            long papersPerStudent = int.Parse(Console.ReadLine());
            decimal paperBoxPrice = decimal.Parse(Console.ReadLine());

            long totalpaper = students * papersPerStudent;
            decimal boxes = (decimal)totalpaper / 500;

            decimal totalSum = boxes * paperBoxPrice;

            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}