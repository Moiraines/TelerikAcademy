using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path //task 4
    {
        private List<Point3D> pointSequence;

        public Path()
        {
            this.pointSequence = new List<Point3D>();
        }

        public List<Point3D> PointSequence
        {
            get { return this.pointSequence; }
            private set { this.pointSequence = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.pointSequence.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pointSequence.Remove(point);
        }
    }
}
