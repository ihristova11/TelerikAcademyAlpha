using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeInSequence
{
    public class RemoveNegativeInSequence
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1, -5, 2, 5, -6, -7, -19, 21 };

            Console.WriteLine($"Positive: {string.Join(" ", list.Where(x => x >= 0))}");
            Console.WriteLine($"Negative: {string.Join(" ", list.Where(x => x < 0))}");
        }
    }
}
