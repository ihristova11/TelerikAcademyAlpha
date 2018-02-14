using System;
using System.Collections.Generic;

namespace NotDivisibleNumber
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            for (int i = 0; i < n + 1; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
