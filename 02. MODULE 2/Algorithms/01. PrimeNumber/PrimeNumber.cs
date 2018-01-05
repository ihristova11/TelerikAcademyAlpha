using System;
using System.Collections.Generic;

namespace _01.PrimeNumber
{
    public class PrimeNumber
    {
        private const int start = 200;
        private const int end = 300;
        private static IList<int> primes = new List<int>();

        public static void Main()
        {
            for (int n = start; n <= end; n++)
            {
                if (IsPrime(n))
                {
                    primes.Add(n);
                }
            }

            Console.WriteLine(string.Join(", ", primes));
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
