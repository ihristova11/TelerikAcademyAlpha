using System;
using System.Linq;

namespace Combinations
{
    public class Combinations
    {
        public class Program
        {
            private static int n;
            static void Main()
            {
                int k = int.Parse(Console.ReadLine()); // number of shirts
                var l = Console.ReadLine().ToCharArray(); // skirts
                n = int.Parse(Console.ReadLine()); // number of girls

                int endNumber = k;
                int combinationLen = n;

                int[] combinationStore = new int[combinationLen];
                GenerateCombination(combinationStore, 0, 1, endNumber, combinationLen);
            }

            public static void GenerateCombination(int[] combinationStore, int counter, int startNumber, int endNumber, int combinationLen)
            {
                //bottom of recursion
                if (counter >= combinationStore.Length)
                {
                    Console.WriteLine(string.Join(" ", combinationStore));
                }
                else
                {
                    for (int i = startNumber; i <= endNumber; i++)
                    {
                        combinationStore[counter] = i;
                        GenerateCombination(combinationStore, counter + 1, i + 1, endNumber, combinationLen);
                    }
                }
            }
        }
    }
}
