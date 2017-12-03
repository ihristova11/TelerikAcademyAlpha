using System;
using System.Globalization;
using System.Threading;

class BiggestOf5Numbers
{
    static void Main()
    {
        {
            double[] arr = new double[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(Math.Max(Math.Max(arr[0], arr[1]), Math.Max(arr[1],arr[2])));
        }
    }
}