using System;

namespace SortableCollection
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 5, 4, 2, 7, -1, 0 };
            int[] sortedNumbers = { 1, 2, 4, 6, 8, 11, 17 };

            var notSorted = new SortableCollection(numbers);
            var sorted = new SortableCollection(sortedNumbers);

            Console.WriteLine("============================");
            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", sortedNumbers));
            Console.WriteLine("============================");
            Console.WriteLine("Not sorted array:");
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Linear search 4:");
            Console.WriteLine(notSorted.LinearSearch(4));
            Console.WriteLine();

            Console.WriteLine("Binary search 3:");
            Console.WriteLine(sorted.BinarySearch(3));
            Console.WriteLine();

            Console.WriteLine("Shuffle:");
            notSorted.Shuffle();
            sorted.Shuffle();
            notSorted.Print();
            sorted.Print();
            Console.WriteLine();


            Console.WriteLine("Shuffle again:");
            notSorted.Shuffle();
            sorted.Shuffle();
            notSorted.Print();
            sorted.Print();
        }
    }
}
