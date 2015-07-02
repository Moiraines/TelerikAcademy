using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Start
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1.5, 2.5, 3.5); //creating points for testing purposes
            Point3D point2 = new Point3D(-1, -4, 7);
            Point3D point3 = new Point3D(1, 2, 3);
            Point3D point4 = new Point3D(-1, -2, 3);
            Point3D point5 = new Point3D(1.25, 2.375, 3.8);

            Path testPath = new Path(); //creating a path of points for testing purposes

            testPath.AddPoint(point1);
            testPath.AddPoint(point2);
            testPath.AddPoint(point3);
            testPath.AddPoint(point4);
            testPath.AddPoint(point5);

            PathStorage.SavePath(testPath, "test"); //saving the test points to the file "test.txt"

            Console.WriteLine("Test file has been created");

            Console.WriteLine(new string('-', 50));

            Path loadedPath = PathStorage.LoadPath(@"../../test.txt"); //loading the saved file and printing the points

            for (int i = 0; i < loadedPath.PointSequence.Count; i++)
            {
                Console.WriteLine(loadedPath.PointSequence[i]);
            }
        }
    }
}
