using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SortableCollection
{
    public class SortableCollection
    {
        public SortableCollection(int[] numbers)
        {
            this.Numbers = numbers;
        }

       public int[] Numbers { get; set; }

        // Implementation of Linear search algorithm (task 1)
        public bool LinearSearch(int desired)
        {
            for (int i = 0; i < this.Numbers.Length; i++)
            {
                if (this.Numbers[i] == desired)
                {
                    return true;
                }
            }

            return false;
        }

        // Implementation of Binary search algorithm (task 2)
        public bool BinarySearchRecursive(int min, int max, int desired)
        {
            int mid = (min + max) / 2;
            int midValue = this.Numbers[mid];

            if (min > max)
            {
                return false;
            }
            else
            {
                if (desired == midValue)
                {
                    return true;
                }
                else if (desired > midValue)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }

                return BinarySearchRecursive(min, max, desired);
            }
        }

        //Implementation of Shuffle algorithm (task 3)
        public int[] Shuffle()
        {
            //get random number
            var random = new Random();

            for (int i = this.Numbers.Length - 1; i > 0; i--)
            {
                //find random index using the random number
                int j = random.Next() % (i + 1);

                //Swap elements
                var temp = this.Numbers[i];
                this.Numbers[i] = this.Numbers[j];
                this.Numbers[j] = temp;
            }

            return this.Numbers;
        }

        public bool BinarySearch(int desired)
        {
            return BinarySearchRecursive(0, this.Numbers.Length - 1, desired);
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", this.Numbers));
        }
    }
}
