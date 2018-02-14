using System;

namespace Calculate_
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double mid = 1;
            long nFac = 1;
            double xPow = x;
            for (int i = 1; i < n + 1; i++)
            {
                nFac *= i;
                xPow = Math.Pow(x, i);
                mid += nFac / xPow;
            }

            Console.WriteLine(string.Format("{0:F5}",mid));
        }
    }
}
