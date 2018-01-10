using System;
using System.IO;

namespace SortableCollection
{
    class SortableCollection
    {
        static void Main()
        {
            int[] numbers = { 1, 5, 4, 2, 7, -1, 0 };
            int[] sortedNumbers = { 1, 2, 4, 6, 8, 11, 17 };
            Console.WriteLine(LinearSearch(numbers, 7));
            Console.WriteLine(BinarySearch(sortedNumbers, 0, sortedNumbers.Length - 1, 6));
        }
        

        // Implementation of Linear search algorithm (task 1)
        public static int LinearSearch(int[] numbers, int desired)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == desired)
                {
                    return i;
                }
            }

            return -1;
        }

        // Implementation of Binary search algorithm (task 2)
        public static int BinarySearch(int[] numbers, int min, int max, int desired)
        {
            int mid = (min + max) / 2;
            int midValue = numbers[mid];

            if (min > max)
            {
                return -1;
            }
            else
            {
                if (desired == midValue)
                {
                    return mid;
                }
                else if (desired > midValue)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }

                return BinarySearch(numbers, min, max, desired);
            }
        }
    }
}
