using System;
using System.Collections.Generic;

namespace MaximalSumOfKElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            int sum = 0;
            for (int i = numbers.Length - 1; i > numbers.Length - 1 - k; i--)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
