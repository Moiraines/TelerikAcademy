namespace Problem_03
{
    using System;

    /*
    Modify the previous program to skip duplicates:
    n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
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

            for (int i = (current == 0 ? 1 : combination[current - 1] + 1); i <= n; i++)
            {
                combination[current] = i;
                GenerateCombinations(current + 1, k, n, combination);
            }
        }
    }
}
