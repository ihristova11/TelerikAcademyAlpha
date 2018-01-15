using System;
using Microsoft.SqlServer.Server;

namespace _04.Permutations
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] used = new bool[n];
            int[] mp = new int[n];

            Permute(0, n, used, mp);
        }

        public static void Permute(int i, int n, bool[] used, int[] mp)
        {
            int k;
            if (i >= n)
            {
                Print(n, mp);
                return;
            }
            for (k = 0; k < n; k++)
            {
                if (!used[k])
                {
                    used[k] = true;
                    mp[i] = k + 1;
                    Permute(i + 1, n, used, mp);
                    used[k] = false;
                }
            }
        }

        public static void Print(int n, int[] mp)
        {
            Console.WriteLine(string.Join(" ", mp));
        }
    }
}
