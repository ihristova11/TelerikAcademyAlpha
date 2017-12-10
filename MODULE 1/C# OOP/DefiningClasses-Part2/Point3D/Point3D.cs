namespace Point3D
{
    using System;

    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D O = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get { return this.x; } }

        public double Y { get { return this.y; } }

        public double Z { get { return this.z; } }

        public static Point3D PointO
        {
            get
            {
                return O;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.x, this.y, this.z);
        }

    }
}
