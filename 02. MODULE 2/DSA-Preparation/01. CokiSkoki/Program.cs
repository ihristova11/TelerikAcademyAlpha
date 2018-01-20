using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CokiSkoki
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var buildings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] sequenceLens = new int[n];
            Stack<int> peeks = new Stack<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                while (peeks.Count != 0 && buildings[peeks.Peek()] <= buildings[i])
                {
                    int peekInd = peeks.Pop();
                    sequenceLens[peekInd] = peeks.Count;
                }

                peeks.Push(i);
            }

            while (peeks.Count != 0)
            {
                int peekInd = peeks.Pop();
                sequenceLens[peekInd] = peeks.Count;
            }

            Console.WriteLine(sequenceLens.Max());
            Console.WriteLine(string.Join(" ", sequenceLens));
        }
    }
}
