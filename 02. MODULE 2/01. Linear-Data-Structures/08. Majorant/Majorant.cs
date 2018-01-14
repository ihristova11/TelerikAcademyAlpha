using System;
using System.Collections.Generic;

namespace _08.Majorant
{
    public class Majorant
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int len = arr.Length;

            FindMajorant(CountOccurrances(arr), len);
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

        public static void FindMajorant(Dictionary<int, int> dictionary, int len)
        {
            List<int> majorants = new List<int>();
            foreach (var element in dictionary)
            {
                if (element.Value >= len / 2 + 1)
                {
                    majorants.Add(element.Key);
                }
            }
            if (majorants.Count == 0)
            {
                Console.WriteLine("No majorants");
            }
            else
            {
                Console.WriteLine(string.Join(" ", majorants));
            }
        }
    }
}
