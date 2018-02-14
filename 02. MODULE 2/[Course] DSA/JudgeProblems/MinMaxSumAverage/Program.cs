using System;
using System.Globalization;
using System.Threading;

class MinMaxSumAverageOfN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n = int.Parse(Console.ReadLine());

        double min = double.MaxValue;
        double max = double.MinValue;

        double number;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());

            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
        }

        Console.WriteLine("min={0:F2} \r\nmax={1:F2} \r\nsum={2:F2} \r\navg={3:F2}", min, max, sum, sum / n);
    }
}