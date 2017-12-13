namespace Point3D
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

       public void AddPoint(Point3D p)
        {
            this.points.Add(p);
        }
    }
}
