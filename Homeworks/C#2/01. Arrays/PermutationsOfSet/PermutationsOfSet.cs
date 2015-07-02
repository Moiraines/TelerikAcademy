//Task 19
//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Permute
{
    private void swap(ref int a, ref int b)
    {
        if (a == b)
        {
            return;
        }
        a ^= b;
        b ^= a;
        a ^= b;
    }

    public void Setper(int[] list)
    {
        int x = list.Length - 1;
        Go(list, 0, x);
    }

    public void Go(int[] list, int k, int m)
    {
        int i;
        if (k == m)
        {
            for (i = 0; i <= m; i++)
            {
                if (i == 0)
                {
                    Console.Write("{" + list[i] + ", ");
                }
                else if (i == m)
                {
                    Console.Write(list[i] + "}");
                }
                else
                {
                    Console.Write(list[i] + ", ");
                }
            }
                
            Console.WriteLine();
        }
        else
        {
            for (i = k; i <= m; i++)
            {
                swap(ref list[k], ref list[i]);
                Go(list, k + 1, m);
                swap(ref list[k], ref list[i]);
            }
        }
    }
}
class PermutationsOfSet
{
    static void Main()
    {
        Permute p = new Permute();
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        Console.WriteLine();
        Console.WriteLine("Permutations: ");
        p.Setper(arr);

    }
}