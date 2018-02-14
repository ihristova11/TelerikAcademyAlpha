using System;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int arraySize = int.Parse(Console.ReadLine());
        string[] values = Console.ReadLine().Split(' ');

        int[] arr = new int[arraySize];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(values[i]);
        }

        count = LargerThanTheNeighbours(arr, count);

        Console.WriteLine(count);
    }

    static int LargerThanTheNeighbours(int[] array, int neighboursCount)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                neighboursCount++;
            }
        }

        return neighboursCount;
    }
}
