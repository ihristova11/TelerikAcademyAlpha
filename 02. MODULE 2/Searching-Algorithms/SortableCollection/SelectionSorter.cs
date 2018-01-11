using System;

namespace SortableCollection
{
    public class SelectionSorter : ISorter
    {
        public void Sort()
        {
            SelectionSort(new SortableCollection(new int[] { 1, 5, 4, 2, 7, -1, 0 }));
        }

        public void SelectionSort(SortableCollection collection)
        {
            int min;
            int temp;
            for (int i = 0; i < collection.Numbers.Length; i++)
            {
                min = collection.Numbers[i];

                for (int j = i + 1; j < collection.Numbers.Length - 1; j++)
                {
                    if (min > collection.Numbers[j])
                    {
                        min = collection.Numbers[j];
                    }

                    //swappint elements
                    collection.Numbers[i] = collection.Numbers[j];
                    collection.Numbers[j] = min;
                }
            }
        }
    }
}
