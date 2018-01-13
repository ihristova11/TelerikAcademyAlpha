using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestSubsequence
{
    public class LongestSubsequence
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1, 3, 2, 3, 4, 5, 6, 4, 5, 6, 6, 7, 8 };

            
        }

        public static void CountOccurrances(IList<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("cannot be empty");
            }

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (dictionary.ContainsKey(numbers[i]))
                {
                    dictionary[numbers[i]]++;
                }
                else
                {
                    dictionary.Add(numbers[i], 1);
                }
            }
        }
    }
}
