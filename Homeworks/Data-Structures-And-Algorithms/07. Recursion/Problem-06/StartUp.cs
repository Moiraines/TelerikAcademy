namespace Problem_06
{
    using System;
    using System.Linq;


    /*
    Write a program for generating and printing all subsets of k strings from given set of strings.
        Example: 
        s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)
    */
    public class StartUp
    {
        private static string[] set = new[] { "test", "rock", "fun" };

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

        private static void Variate(int current, int n, int k, int[] combination)
        {
            if (current == k)
            {
                Console.Write("({0}), ", string.Join(", ", combination.Select(i => set[i])));
                return;
            }

            for (int i = (current == 0) ? 0 : combination[current - 1] + 1; i < n; i++)
            {
                combination[current] = i;
                Variate(current + 1, n, k, combination);
            }
        }
    }
}
