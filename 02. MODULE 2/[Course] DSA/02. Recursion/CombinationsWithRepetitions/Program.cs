using System;
using System.Linq;

namespace Combinatios
{
    public class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int endNumber = input[0];
            int combinationLen = input[1];

            int[] combinationStore = new int[combinationLen];
            GenerateCombination(combinationStore, 0, 1, endNumber, combinationLen);
        }

        public static void GenerateCombination(int[] combinationStore, int counter, int startNumber, int endNumber, int combinationLen)
        {
            if (counter >= combinationStore.Length)
            {
                Console.WriteLine(string.Join(" ", combinationStore));
            }
            else
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    combinationStore[counter] = i;
                    GenerateCombination(combinationStore, counter + 1, i, endNumber, combinationLen);
                }
            }
        }
    }
}
