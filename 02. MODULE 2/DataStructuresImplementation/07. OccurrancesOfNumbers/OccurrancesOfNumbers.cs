using System;
using System.Collections.Generic;

namespace _07.OccurrancesOfNumbers
{
    public class OccurrancesOfNumbers
    {
        static void Main()
        {
            int[] array = new int[]{ 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            PrintDictionary(CountOccurrances(array));
        }

        public static SortedDictionary<int, int> CountOccurrances(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("array cannot be empty");
            }

            SortedDictionary<int, int> numbersOccurrances = new SortedDictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (numbersOccurrances.ContainsKey(arr[i]))
                {
                    numbersOccurrances[arr[i]]++;
                }
                else
                {
                    numbersOccurrances.Add(arr[i], 1);
                }
            }

            return numbersOccurrances;
        }

        public static void PrintDictionary(SortedDictionary<int, int> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key} --> {element.Value} times");
            }
        }
    }
}
