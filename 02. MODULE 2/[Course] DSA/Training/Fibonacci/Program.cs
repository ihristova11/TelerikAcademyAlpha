using System;

namespace Fibonacci
{
    public class Program
    {
        static int result = 0;

        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Sum(0, arr));
        }

        private static int Sum(int ind, int[] arr)
        {
            if (ind > arr.Length - 1) return 0;
            
            return arr[ind] + Sum(ind + 1, arr);
        }
    }
}
