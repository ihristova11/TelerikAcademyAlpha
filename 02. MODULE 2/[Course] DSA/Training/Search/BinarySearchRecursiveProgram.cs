using System;

namespace Search
{
    public class BinarySearchRecursiveProgram
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 4, 6, 7, 8, 9 };
            Console.WriteLine(BinarySearchRecursive(0, arr.Length - 1, 4, arr));
        }

        private static int BinarySearchRecursive(int left, int right, int searched, int[] arr)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            if (searched == arr[mid])
            {
                return ++mid;
            }
            else if (searched < arr[mid])
            {
                right = mid - 1;
                return BinarySearchRecursive(left, right, searched, arr);
            }
            else
            {
                left = mid + 1;
                return BinarySearchRecursive(left, right, searched, arr);
            }
        }
    }
}
