namespace Cooking
{
    using System;

    public class IfsRefacture
    {
        ////Setting constants for the Task 2 here
        public const int MinX = 10;
        public const int MaxX = 100;
        public const int MinY = 20;
        public const int MaxY = 80;

        public static void Main()
        {
            ////Task 1
            Potato potato = new Potato();
            ////... 
            if (potato == null)
            {
                throw new ArgumentNullException("Potato is not assigned");
            }
            else
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
                
            ////Task 2
            bool shouldVisitCell = false;
            int x = 0;
            int y = 0;

            ////some code...
            bool isXInRange = IsInRange(x, MinX, MaxX);
            bool isYInRange = IsInRange(y, MinY, MaxY);

            if (isXInRange && isYInRange && shouldVisitCell)
            {
               VisitCell();
            }
        }

        /// <summary>
        /// method for Task1
        /// </summary>
        /// <param name="input">vegetable(potato) for cooking</param>
        public static void Cook(Potato input) 
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// method for Task2
        /// </summary>
        public static void VisitCell()
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// method for Task2
        /// </summary>
        /// /<param name="value">value which is checked if is in range or not</param>
        /// <param name="start">start number of the interval</param>
        /// <param name="end">end number of the interval</param>
        public static bool IsInRange(int value, int start, int end)
        {
            if (start <= value && value <= end) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
