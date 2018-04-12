using System;

namespace BinarySearchIterative
{
    public class BinarySearchIterative
    {
        public static void Main()
        {
            int[] arr = {1, 2, 3, 4, 5, 7, 9, 43};

            int left = 0;
            int right = arr.Length - 1;

            int searched = 9;

            Console.WriteLine(BinarySearch(searched, arr, left, right));
        }

        private static int BinarySearch(int searched, int[] arr, int left, int right)
        {
            int foundIndex = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (searched == arr[mid])
                {
                    foundIndex = ++mid;
                    break;
                }
                else if (searched < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return foundIndex;
        }
    }
}
