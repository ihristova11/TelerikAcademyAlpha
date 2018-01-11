using System;

namespace SortableCollection
{
    //task 1
    public class SelectionSorter : ISorter
    {
        public void Sort(int[] collection)
        {
            SelectionSort(collection);
        }

        // Implementation of Selection Sort Algorithm

        // for every element in the collection 
        //let the element be min and then for all elements smaller than our min -> swap
        public void SelectionSort(int[] collection)
        {
            int min;
            int temp;
            for (int i = 0; i < collection.Length - 1; i++)
            {
                //try every element as min
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
