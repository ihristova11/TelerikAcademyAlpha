using System;
using System.Collections.Generic;

namespace _01.SumAndAverageOfElements
{
    public class SumAndAverageOfElements
    {
        static void Main()
        {
            List<int> sequence = new List<int>();

            while (true)
            {
                try
                {
                    sequence.Add(int.Parse(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    break;
                }
            }

            Console.WriteLine(FindSum(sequence));
            Console.WriteLine(FindAverage(sequence));
        }

        private static  double FindSum(List<int> sequence)
        {
            var sum = 0;
            foreach (var number in sequence)
            {
                sum += number;
            }

            return sum;
        }

        private static double FindAverage(List<int> sequence)
        {
            return FindSum(sequence) / sequence.Count;
        }
    }
}
