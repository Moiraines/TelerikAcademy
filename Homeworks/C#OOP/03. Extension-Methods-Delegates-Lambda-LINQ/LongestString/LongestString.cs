//Task 17
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
namespace LongestString
{
    using System.Linq;
    class LongestString
    {
        static void Main()
        {
            string[] myString = 
            {
                "kralimarko",
                "babaminkovica",
                "talasumiood",
                "kalimqvka",
            };

            var orderedArray =
                from strings in myString
                orderby strings.Length descending
                select strings;

            string longest = orderedArray.FirstOrDefault();

            System.Console.WriteLine(longest);
        }
    }
}
