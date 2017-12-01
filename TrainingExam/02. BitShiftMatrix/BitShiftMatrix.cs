namespace _02.BitShiftMatrix
{
    using System;
    using System.Linq;

    class BitShiftMatrix
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int r = input[0];
            int c = input[1];
        }
    }
}
