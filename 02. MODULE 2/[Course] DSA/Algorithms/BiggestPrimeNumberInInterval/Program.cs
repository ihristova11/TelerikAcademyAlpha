using System;
using System.Linq;

namespace BiggestPrimeNumberInInterval
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            primes[0] = true;
            primes[1] = true;
            for (int num = 1; num < primes.Length; num++)
            {
                if (primes[num] == false)
                {
                    for (int multiplier = 2; multiplier * num < primes.Length; multiplier++)
                    {
                        primes[multiplier * num] = true;
                    }
                }
            }

            int x = primes.Length - 1;

            while (true)
            {
                if (primes[x] == false)
                {
                    Console.WriteLine(x);
                    break;
                }
                --x;
            }
        }
    }
}
