using System;

namespace Trapezoid
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n) + new string('*', n));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(new string('.', n - i) + "*" + new string('.', n + i - 2) + "*");
            }

            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
