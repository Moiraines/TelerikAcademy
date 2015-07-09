////Task Description is in its respected file in same project
namespace ExamCSharp1Task4 
{
    using System;

    public class CubeDrawer
    {
        public static void Main()
        {
            int cubeSideBlocks = int.Parse(Console.ReadLine());

            PictureDraw(cubeSideBlocks);
        }

        public static void PictureDraw(int cubeSideBlocks)
        {
            ////drawing first row of the picture
            Console.Write(new string(' ', cubeSideBlocks - 1));
            Console.WriteLine(new string(':', cubeSideBlocks));

            ////draw the top part of the cube
            TopPartDraw(cubeSideBlocks);

            ////draw the middle(biggest) row of the picture
            Console.Write(new string(':', cubeSideBlocks));
            Console.Write(new string('X', cubeSideBlocks - 2));
            Console.WriteLine(":");

            ////draw the bottom part of the cube
            BottomPartDraw(cubeSideBlocks);

            ////draw the final tow rows in the picture
            Console.Write(":");
            Console.Write(new string(' ', cubeSideBlocks - 2));
            Console.WriteLine(new string(':', 2));
            Console.Write(new string(':', cubeSideBlocks));
            Console.WriteLine(new string(' ', cubeSideBlocks - 1));
        }

        public static void TopPartDraw(int cubeSideBlocks) 
        {
            int counterXElements = 0;
            for (int i = cubeSideBlocks - 2; i > 0; i--)
            {
                Console.Write(new string(' ', i));
                Console.Write(":");
                Console.Write(new string('/', cubeSideBlocks - 2));
                Console.Write(":");
                Console.Write(new string('X', counterXElements));
                counterXElements++;
                Console.WriteLine(":");
            }
        }

        public static void BottomPartDraw(int cubeSideBlocks)
        {
            for (int i = cubeSideBlocks - 3; i > 0; i--)
            {
                Console.Write(":");
                Console.Write(new string(' ', cubeSideBlocks - 2));
                Console.Write(":");
                Console.Write(new string('X', i));
                Console.WriteLine(":");
            }
        }
    }
}