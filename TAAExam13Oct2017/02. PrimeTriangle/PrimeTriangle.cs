using System;
using System.Collections.Generic;

class PrimeTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int boundary = (int)(Math.Floor(Math.Sqrt(n)));
        List<int> primes = new List<int>(2);
        primes[0] = 1;
        primes[1] = 2;
        if (n < 3)
        {

        }
        else
        {
            for (int i = 3; i <= boundary; i += 2)
            {
                if(n % i == 0)
                {
                    primes.Add(i);
                }
            }
        }
    }
}

