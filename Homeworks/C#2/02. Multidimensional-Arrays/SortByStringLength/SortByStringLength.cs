//Task 5
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SortByStringLength
    {
        static void Main()
        {
            String[] beers = 
            {   "Zagorka", 
                "Ariana",
                "Shumensko",
                "Astika", 
                "Kamenitza", 
                "Bolqrka",
                "Amstel"};

            Array.Sort(beers, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Sorted: {0}", String.Join(", ", beers));
        }
    }
