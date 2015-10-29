using System.Runtime.InteropServices;

namespace Problem10
{
    using System;
    using System.Collections.Generic;

    /*We are given numbers N and M and the following operations:
        N = N+1
        N = N+2
        N = N*2
        
        Write a program that finds the shortest sequence of operations from the list above that starts from N and 
        finishes in M.
        
        Hint: use a queue.
        Example: N = 5, M = 16
        Sequence: 5 → 7 → 8 → 16*/

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter number N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number M bigger then N with at least 1:");
            int m = int.Parse(Console.ReadLine());

            var queue = new Queue<int>();
            queue.Enqueue(n);
            int current = n;

            while (current * 2 < m / 2)
            {
                current = OperationThird(current);
                queue.Enqueue(current);
            }

                if (current > m/2)
                {
                    while (true)
                    {
                        if (current == m)
                        {
                            break;
                        }
                        else if(current == m-1)
                        {
                            current = OperationFirst(current);
                            break;
                        }

                        current = OperationSecond(current);
                        queue.Enqueue(current);
                    }
                }
                else if (current < m/2)
                {
                    while (true)
                    {
                        if (current == m / 2)
                        {   
                            current = OperationThird(current);
                            break;
                        }
                        else if (current == m / 2 - 1)
                        {
                            current = OperationFirst(current);
                            queue.Enqueue(current);
                            current = OperationThird(current);
                            break;
                        }

                        current = OperationSecond(current);
                        queue.Enqueue(current);
                    }
                }
                else
                {
                    current = OperationThird(current);
                }

                queue.Enqueue(current);

            Console.WriteLine("Sequence: ");
            foreach (var number in queue)
            {
                Console.Write("{0}, ", number);
            }

            Console.WriteLine();
        }

        private static int OperationFirst(int number)
        {
            return number + 1;
        }

        private static int OperationSecond(int number)
        {
            return number + 2;
        }

        private static int OperationThird(int number)
        {
            return 2 * number;
        }
    }
}
