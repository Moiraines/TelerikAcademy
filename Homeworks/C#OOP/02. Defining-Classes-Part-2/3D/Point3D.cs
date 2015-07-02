namespace Point3D
{
    using System;
    using System.Text;
    public struct Point3D
    {
        private static readonly Point3D o; // task 2
        private double x { get; set; } //task 1
        private double y { get; set; } //task 1
        private double z { get; set; } //task 1

        //task 1 - set a constructor

        public Point3D(double X, double Y, double Z) : this() 
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        static Point3D()
        {
            o = new Point3D(0, 0, 0); 
        }

        //task 2 - property for the static field

        public static Point3D O
        {
            get { return o; }
        }

        //task 1 - properties for the fields

        public double X
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            private set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            private set { this.z = value; }
        }

        public override string ToString()
        {
            return String.Format("Coordinates X = {0}, Y = {1}, Z = {2}", this.x, this.y, this.z);
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file 
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        } 
    }
}
