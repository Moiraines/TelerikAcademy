using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\" + fileName + ".txt"))
            {
                for (int i = 0; i < path.PointSequence.Count; i++)
                {
                    sw.WriteLine(path.PointSequence[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }

            return path;
        }


    }
}
