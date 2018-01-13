using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _06.RemoveOddOccurrences
{
    public class RemoveOddOccurrences
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Console.WriteLine(string.Join(" ", numbers));

            Console.WriteLine(string.Join(" ", RemoveOddOccurrances(numbers)));
        }

        public static Dictionary<int, int> CountOccurrances(IList<int> numbers)
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

            return dictionary;
        }

        public static IList<int> RemoveOddOccurrances(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("cannot be empty");
            }

            Dictionary<int, int> occurrances = CountOccurrances(numbers);

            foreach (var element in occurrances)
            {
                if (element.Value % 2 == 1)
                {
                    numbers.RemoveAll(e => e == element.Key);
                }
            }

            return numbers;
        }
    }
}
