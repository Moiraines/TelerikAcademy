namespace Problem_05
{
    using System;
    using System.Linq;

    /*
    Write a recursive program for generating and printing all ordered k-element subsets from n-element set 
    (variations Vkn).
        Example: 
        n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
    */
    public class StartUp
    {
        private static string[] set = new[] { "hi", "a", "b" };

        public static void Main()
        {
            int n = set.Length;
            int k = 2;

            if (!(0 < k && k <= n))
            {
                throw new InvalidOperationException();
            }

            Variate(0, n, k, new int[k]);
            Console.WriteLine();
        }

        private static void Variate(int current, int n, int k, int[] variation)
        {
            if (current == k)
            {
                Console.Write("({0}), ", string.Join(", ", variation.Select(i => set[i])));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                variation[current] = i;
                Variate(current+1, n, k, variation);
            }
        }
    }
}
