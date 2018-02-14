using System;
using System.Numerics;

namespace CalculateAgain
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger nFac = 1;
            BigInteger kFac = 1;

            for (int i = 2; i < n + 1; i++)
            {
                if (i <= k)
                {
                    kFac *= i;
                }

                nFac *= i;
            }

            Console.WriteLine(nFac / kFac);
        }
    }
}
