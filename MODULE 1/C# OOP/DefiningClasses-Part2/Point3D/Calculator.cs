namespace Point3D
{
    using System;

    public static class Calculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow(2, firstPoint.X - secondPoint.X) + Math.Pow(2, firstPoint.Y - secondPoint.Y) + Math.Pow(2, firstPoint.Z - secondPoint.Z));

            return distance;
        }

    }
}
