namespace MethodPrintStatistics
{
    public class MethodPrintStatistics
    {
        public static void Main(string[] args)
        {
            ////Some code...
        }

        /// <summary>
        /// find the min value, max value and average value of the first n elements of a given array
        /// </summary>
        /// <param name="collection">the array which method is called for</param>
        /// <param name="elementsCounts">count of the first n elements we need to check</param>
        public void PrintStatistics(double[] collection, int elementsCounts)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double elementsSum = 0;

            for (int i = 0; i < elementsCounts; i++)
            {
                if (collection[i] > maxValue)
                {
                    maxValue = collection[i];
                }

                if (collection[i] < minValue)
                {
                    minValue = collection[i];
                }

                elementsSum += collection[i];
            }

            double averageSum = elementsSum / elementsCounts;

            ////don't know what these three methods are doing, but they seem stupid enough so it's ok...  :)
            PrintAvg(averageSum);
            PrintMax(maxValue);
            PrintMin(maxValue);
        }
    }
}
