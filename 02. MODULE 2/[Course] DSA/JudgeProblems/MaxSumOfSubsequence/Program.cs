using System;
using System.Collections.Generic;

namespace MaxSumOfSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(GetBestSequence(numbers));
        }

        private static int GetBestSequence(IEnumerable<int> numbers)
        {
            //Kadane's algorithm

            int tempSum = 0;
            int bestSum = 0;

            foreach (var number in numbers)
            {
                tempSum += number;
                if (tempSum <= 0)
                {
                    tempSum = 0;
                }
                else if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                }
            }

            return bestSum;
        }
    }
}
