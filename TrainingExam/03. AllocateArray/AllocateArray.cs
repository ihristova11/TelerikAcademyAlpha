namespace _03.AllocateArray
{
    using System;

    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i * 5;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
