namespace Problem_01
{
    using System;

    /*
    Write a recursive program that simulates the execution of n nested loops from 1 to n.

        Examples:
                 1 1
        n=2  ->  1 2
                 2 1
                 2 2
        
                 1 1 1
                 1 1 2
                 1 1 3
                 1 2 1
        n=3  ->  ...
                 3 2 3
                 3 3 1
                 3 3 2
                 3 3 3
    */
    public class StartUp
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            NestedLoops(0, N, new int[N]);
            
        }

        public static void NestedLoops(int number, int N, int[] array)
        {
            if (number >= N)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                array[number] = i;
                NestedLoops(number + 1, N, array);
            }
        }
    }
}
