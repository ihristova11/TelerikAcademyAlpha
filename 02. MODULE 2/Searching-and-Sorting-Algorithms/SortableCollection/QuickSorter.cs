using System;

namespace SortableCollection
{
    public class QuickSorter : ISorter
    {
        public void Sort(int[] collection)
        {
            QuickSort(collection, 0, collection.Length - 1);

            Console.WriteLine(string.Join(" ", collection));
        }

        public void QuickSort(int[] collection, int left, int right)
        {
            int i = left, j = right;
            int pivot = collection[(left + right) / 2];

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = tmp;

                    i++;
                    j--;
                }

                // Recursive calls
                if (left < j)
                {
                    QuickSort(collection, left, j);
                }

                if (i < right)
                {
                    QuickSort(collection, i, right);
                }
            }
        }
    }
}
