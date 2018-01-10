using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestSubsequence
{
    class LongestSubsequence
    {
        static void Main()
        {
            List<int> seq = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(FindLongest(seq));
        }

        private static int FindLongest(List<int> seq)
        {
            int best = 1;
            int counter = 1;
            for (int i = 1; i < seq.Count; i++)
            {
                if (seq[i - 1] == seq[i])
                {
                    counter++;

                    best = best < counter ? counter : best;
                }
                else
                {
                    counter = 1;
                }
            }

            return best;
        }
    }
}
