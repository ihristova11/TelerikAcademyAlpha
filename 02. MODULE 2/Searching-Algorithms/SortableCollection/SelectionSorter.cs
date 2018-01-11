using System;

namespace SortableCollection
{
    public class SelectionSorter : ISorter
    {
        public void Sort(int[] collection)
        {
            SelectionSort(collection);
        }

        public void SelectionSort(int[] collection)
        {
            int min;
            int temp;
            for (int i = 0; i < collection.Length - 1; i++)
            {
                min = collection[i];

                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (min > collection[j])
                    {
                        min = collection[j];

                        //swapping elements
                        temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
