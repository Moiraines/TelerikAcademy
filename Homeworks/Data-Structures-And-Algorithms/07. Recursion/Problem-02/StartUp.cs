using System;

namespace Problem_02
{
    /*
    Write a recursive program for generating and printing all the combinations with duplicatesof k elements from 
    n-element set. Example:
    n=3, k=2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
    */
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());
            GenerateCombinations(0, k, n, new int[k]);
            Console.WriteLine();
        }

        private static void GenerateCombinations(int current, int k, int n, int[] combination)
        {
            if (current >= k)
            {
                Console.Write("(" + string.Join(", ", combination) + "), ");
                return;
            }

            for (int i = (current == 0 ? 1 : combination[current-1]); i <= n; i++)
            {
                combination[current] = i;
                GenerateCombinations(current + 1, k, n, combination);
            }
        }
    }
}
