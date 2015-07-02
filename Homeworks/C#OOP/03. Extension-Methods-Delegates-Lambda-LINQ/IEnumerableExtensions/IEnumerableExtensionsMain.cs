//Task 2
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            //Testing of the various extensions for different types of collections and elements:

            IEnumerable<int> test = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(test.SumOfCollection());
            IEnumerable<double> test1 = new[] { 1.5, 2.5, 3.5, 4.5, 5.5 };

            Console.WriteLine(test1.SumOfCollection());
            Console.WriteLine(test1.ProductOfCollection());
            Console.WriteLine(test1.MinOfCollection());
            Console.WriteLine(test1.MaxOfCollection());
            Console.WriteLine(test1.AverageOfCollection());

            Console.WriteLine(IEnumerableExtensions.AverageOfCollection(test));
            Console.WriteLine(IEnumerableExtensions.ProductOfCollection(test1));
        }
    }
}
