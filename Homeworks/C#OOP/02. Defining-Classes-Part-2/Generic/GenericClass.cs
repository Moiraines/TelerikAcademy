using System;
namespace Generic
{
    class GenericClass
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>(4);

            //testing Add and Capacity
            for (int i = 0; i < 20; i++)  
            {
                testList.Add(i + 1);
                Console.WriteLine("Element: {0}, Count: {1} Capacity: {2}",
                    testList[i], testList.Count, testList.Capacity);
            }


            //testing InsertAt and RemoveAt
            for (int i = 0; i < testList.Count; i += 3) 
            {
                testList.InsertAt(i, 50);
            }

            for (int i = 0; i < testList.Count; i += 4)
            {
                testList.RemoveAt(i);
            }

            Console.WriteLine(testList);

            //ToString, Min and Max
            Console.WriteLine("Min: {0}", testList.Min());
            Console.WriteLine("Max: {0}", testList.Max());
        }
    }
}
