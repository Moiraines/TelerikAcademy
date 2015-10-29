namespace Problem09
{
    using System;
    using System.Collections.Generic;

    /*We are given the following sequence:

        S1 = N;
        S2 = S1 + 1;
        S3 = 2*S1 + 1;
        S4 = S1 + 2;
        S5 = S2 + 1;
        S6 = 2*S2 + 1;
        S7 = S2 + 2;
        ...
        Using the Queue<T> class write a program to print its first 50 members for given N.
        Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...*/

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please enter N number:");
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int counter = 0;

            Console.WriteLine("The Sequence is: ");
            while (counter < 50)
            {
                counter++;
                int current = queue.Dequeue();

                Console.WriteLine("Number {0} = {1}", counter, current);

                 if (counter <= 17) //Magic number here. Judge me harder!!!
                {
                    queue.Enqueue(current + 1);
                    queue.Enqueue(2 * current + 1);
                    queue.Enqueue(current + 2);
                }
                
            }
        }
    }
}
