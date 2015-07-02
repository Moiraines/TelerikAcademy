//Task 7
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SelectionSortRecursive
    {
        static void Main()
        {
            Console.WriteLine("Enter an array's length: ");
            int n = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();
            List<int> sortedList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element:");
                int index = int.Parse(Console.ReadLine());
                myList.Add(index);
            }

            // declare a variable holds smallest element
            int smallestEl = int.MaxValue;

            //return the Sort method
            Sort(myList, sortedList, smallestEl);


            //Print sorted List(Array)
            Console.Write("The Sorted array is");
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (i == sortedList.Count - 1)
                {
                    Console.Write("{0}", sortedList[i]);
                }
                else
                {
                    Console.Write("{0}, ", sortedList[i]);
                }
            }
            Console.WriteLine();
	        
            
        }

        //Sort method with recursion
        public static void Sort(List<int> myList, List<int> sortedList, int smallestEl)
        {
           
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList.Count == 1)
                {
                    sortedList.Add(myList[i]);
                    return;
                }

                if (myList[i] < smallestEl)
                {
                    smallestEl = myList[i];
                }
                
            }
            sortedList.Add(smallestEl);
            myList.Remove(smallestEl);

            smallestEl = int.MaxValue;
            Sort(myList, sortedList, smallestEl);
        }
  
                
        
    }
