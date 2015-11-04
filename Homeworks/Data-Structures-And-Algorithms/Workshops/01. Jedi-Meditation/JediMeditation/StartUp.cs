namespace JediMeditation
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            var lineArr = line.Split(' ');

            var masterQueue = new Queue<string>();
            var knightQueue = new Queue<string>();
            var padawanQueue = new Queue<string>();

            string element;
            for (int i = 0; i < n; i++)
            {
                element = lineArr[i];
                switch (element[0])
                {
                    case'm':
                        { masterQueue.Enqueue(element);}
                        break;
                    case 'k':
                        { knightQueue.Enqueue(element); }
                        break;
                    case 'p':
                        { padawanQueue.Enqueue(element); }
                        break;
                    default:
                        break;
                }
            }

            Console.Write(string.Join(" ", masterQueue));
            Console.Write(" ");
            Console.Write(string.Join(" ", knightQueue));
            Console.Write(" ");
            Console.Write(string.Join(" ", padawanQueue));
            Console.WriteLine();
        }
    }
}
