using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Permute(arr, 1, n);
    }

    static void Permute(int[] arry, int i, int n)
    {
        int j;
        if (i == n)
            Console.WriteLine(arry);
        else
        {
            for (j = i; j <= n; j++)
            {
                Swap(ref arry[i], ref arry[j]);
                Permute(arry, i + 1, n);
                Swap(ref arry[i], ref arry[j]); //backtrack
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int tmp;
        tmp = a;
        a = b;
        b = tmp;
    }
}