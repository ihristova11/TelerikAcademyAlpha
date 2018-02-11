using System;
using System.Numerics;

namespace NFactorial
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger bg = 1;
            for (int i = 1; i <= n; i++)
            {
                bg *= i;
            }

            Console.WriteLine(bg);
        }
    }
}
