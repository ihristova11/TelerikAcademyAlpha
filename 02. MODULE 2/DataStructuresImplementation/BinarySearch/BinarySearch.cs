using System;

namespace BinarySearch
{
    public class BinarySearch
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 5, 8, 9, 10 };

            int wanted = 1;
            int min = 0;
            int max = arr.Length;
            Console.WriteLine(Binary(wanted, min, max, arr));
        }

        private static int Binary(int wanted, int min, int max, int[] arr)
        {
            var midInd = (min + max) / 2;
            var midValue = arr[midInd];

            if (min > max)
            {
                return -1;
            }
            else
            {
                if (wanted == midValue)
                {
                    return midInd;
                }
                else if (wanted < midValue)
                {
                    max = midInd - 1;
                }
                else
                {
                    min = midInd + 1;
                }
                return Binary(wanted, min, max, arr);
            }
        }
    }
}
