//Task 5
//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
namespace _64BitArray
{
    using System;
    class BitArray64Main
    {
        static void Main()
        {
            BitArray64 arrayFirst = new BitArray64(25u);
            BitArray64 arraySecond = new BitArray64(16u);

            Console.WriteLine(arrayFirst);
            arrayFirst[1] = 1;
            Console.WriteLine(arrayFirst);

            Console.WriteLine(arrayFirst == arraySecond);
            Console.WriteLine(arrayFirst.Equals(arraySecond));
            Console.WriteLine(arrayFirst != arraySecond);
        }
    }
}
