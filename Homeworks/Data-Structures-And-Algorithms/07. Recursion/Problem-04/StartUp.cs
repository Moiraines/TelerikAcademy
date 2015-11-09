namespace Problem_04
{
    using System;

    /*
    Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given 
    integer number n. 
    Example:
        n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
    */
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            GeneratePermutations(0, n, new int[n], new bool[n]);
            Console.WriteLine();
        }

        private static void GeneratePermutations(int current, int n, int[] permutation, bool[] used)
        {
            if (current == n)
            {
                Console.Write("(" + string.Join(", ", permutation) + "), ");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (used[i])
                {
                    continue;
                }

                permutation[current] = i + 1;
                used[i] = true;
                GeneratePermutations(current + 1, n , permutation, used);
                used[i] = false;
            }
        }
    }
}
