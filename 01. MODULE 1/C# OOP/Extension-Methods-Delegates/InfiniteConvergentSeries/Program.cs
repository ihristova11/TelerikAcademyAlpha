using System;

namespace InfiniteConvergentSeries
{
    public class Program
    {
        public delegate double ConvergetSeriesDelegate(int first, double q);

        static void Main()
        {
            //int first = int.Parse(Console.ReadLine());
            //int q = int.Parse(Console.ReadLine());

            int first = 1;
            double q = 0.5;

            ConvergetSeriesDelegate del = new ConvergetSeriesDelegate(FindSumOfGeometricSequence);
            var result = del(first, q);
            Console.WriteLine(result);
        }

        public static double FindSumOfGeometricSequence(int first, double q)
        {
            double result = first / (1 - q);
            return result;
        }
    }
}
