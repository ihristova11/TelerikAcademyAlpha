using System;
using System.Collections.Generic;
using System.Linq;

namespace CokiSkoki
{
    public class CokiSkoki
    {
        static void Main()
        {
            //get the input data
            int n = int.Parse(Console.ReadLine());

            int[] buildingsHeight = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> peekIndices = new Stack<int>();
            int[] pathLengths = new int[n];

            for (int index = buildingsHeight.Length - 1; index >= 0; index--)
            {
                while (peekIndices.Count != 0 && buildingsHeight[peekIndices.Peek()] < buildingsHeight[index] )
                {
                    int peekIndex = peekIndices.Pop();
                    pathLengths[peekIndex] = peekIndices.Count();
                }

                peekIndices.Push(index);
            }

            while (peekIndices.Count != 0)
            {
                int peekIndex = peekIndices.Pop();
                pathLengths[peekIndex] = peekIndices.Count();
            }

            Console.WriteLine(pathLengths.Max());
            Console.WriteLine(string.Join(" ", pathLengths));
        }
    }
}
