using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string n = Console.ReadLine();
        //int sum = 0;
        //int sum_f = 0;
        if (double.Parse(n) < 0) n = n.Remove(0, 1);
        for (int j = 0; j < n.Length; j++)
        {
            if (n[j] == '.')
            {
                n = n.Remove(j, 1);
            }
        }

        BigInteger number = BigInteger.Parse(n);

        number = CycleIt(number);
        while (number > 9)
        {
            number = CycleIt(number);
        }
        Console.WriteLine(number);
    }

    static int CycleIt(BigInteger number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += (int)(number % 10);
            number /= 10;
        }
        return sum;
    }
}

