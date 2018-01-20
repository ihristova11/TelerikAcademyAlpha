using System;

namespace SortableCollection
{
    public class MergeSorter : ISorter
    {
        public void Sort(int[] collection)
        {
            SortArray(collection, 0, collection.Length - 1);

            Console.WriteLine(string.Join(" ", collection));
        }


        private void SortArray(int[] collection, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var mid = (left + right) / 2;
            this.SortArray(collection, left, mid);
            this.SortArray(collection, mid + 1, right);

            this.MergeArrays(collection, left, mid + 1, right);
        }

        private void MergeArrays(int[] numbers, int left, int mid, int right)
        {
            var numbersCount = right - left + 1;
            var leftEnd = mid - 1;
            var position = left;
            var temp = new int[numbers.Length];

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left].CompareTo(numbers[mid]) < 1)
                {
                    temp[position++] = numbers[left++];
                }
                else
                {
                    temp[position++] = numbers[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[position++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[position++] = numbers[mid++];
            }

            for (var index = numbersCount - 1; index >= 0; index--)
            {
                numbers[right] = temp[right];
                --right;
            }
        }

    }
}
