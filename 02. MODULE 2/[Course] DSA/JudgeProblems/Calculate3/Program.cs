using System;
using System.Numerics;

namespace Calculate3
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            BigInteger kFac = 1;
            BigInteger nFac = 1;
            BigInteger diffFac = 1;
            

            for (int counter = 2; counter <= n; counter++)
            {
                if (counter <= n - k)
                {
                    diffFac *= counter;
                }

                if (counter <= k)
                {
                    kFac *= counter;
                }

                nFac *= counter;
            }

            nFac /= kFac;
            nFac /= diffFac;
            Console.WriteLine(nFac);
        }
    }
}
