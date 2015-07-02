namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class IEnumerableExtensions
    {
        public static T SumOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;

            foreach (T item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T ProductOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)1;

            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Min();
        }

        public static T MaxOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }

        public static T AverageOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
           

            return (dynamic)collection.SumOfCollection() / collection.Count();
        }
    }
}
