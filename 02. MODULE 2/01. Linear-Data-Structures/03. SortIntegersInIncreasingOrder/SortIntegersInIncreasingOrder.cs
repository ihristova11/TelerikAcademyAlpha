using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortIntegersInIncreasingOrder
{
    public class SortIntegersInIncreasingOrder
    {
        static void Main()
        {
            List<int> sequence = new List<int>();
            string line = Console.ReadLine();
            while (line != string.Empty)
            {
                sequence.Add(int.Parse(line));
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", sequence.OrderBy(x => x)));
        }
    }
}
